﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurkiyeSporSistemi.ConsoleUI.Model;
using TurkiyeSporSistemi.ConsoleUI.Repository.Abstaracts;

namespace TurkiyeSporSistemi.ConsoleUI.Repository.Concrete;

public class TeamRepository : IRepository<Team, Guid>
{
    public Team Add(Team created)
    {
        BaseRepository.Teams.Add(created);
        return created;
    }

    public Team? Delete(Guid id)
    {
        Team? team = GetById(id);

        BaseRepository.Teams.Remove(team);

        return team;
    }

    public List<Team> GetAll()
    {
        return BaseRepository.Teams;
    }

    public Team? GetById(Guid id)
    {
        Team? team = BaseRepository
        .Teams
        .SingleOrDefault(x => x.Id == id);

        if (team is null)
        {

            throw new Exception($"Aradığınız Id ye göre Takım bulunamadı : {id}");
        }
        return team;
    }

    public Team? Update(Guid id, Team entity)
    {
        Team? team = GetById(id);
        int index = BaseRepository.Teams.IndexOf(team);
        BaseRepository.Teams.Remove(team);

        BaseRepository.Teams.Insert(index, entity);

        return team;
    }
}
