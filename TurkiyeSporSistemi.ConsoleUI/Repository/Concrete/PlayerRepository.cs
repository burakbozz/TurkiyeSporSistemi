﻿
using TurkiyeSporSistemi.ConsoleUI.Exceptions;
using TurkiyeSporSistemi.ConsoleUI.Model;
using TurkiyeSporSistemi.ConsoleUI.Repository.Abstaracts;

namespace TurkiyeSporSistemi.ConsoleUI.Repository.Concrete;

public class PlayerRepository : IRepository<Player, int>
{
    public Player Add(Player created)
    {
        BaseRepository.Players.Add(created);
        return created;
    }

    public Player? Delete(int id)
    {
        Player? player = GetById(id);

        BaseRepository.Players.Remove(player);

        return player;
    }

    public List<Player> GetAll()
    {
        return BaseRepository.Players;
    }

    public Player? GetById(int id)
    {
        Player? player = BaseRepository
            .Players
            .SingleOrDefault(x => x.Id == id);

        if (player is null)
        {

            throw new NotFoundException($"Aradığınız Id ye göre Oyuncu bulunamadı : {id}");
        }
        return player;
    }

    //  1 , 2 3 , 4 , 5 , 6
    public Player? Update(int id, Player entity)
    {
        Player? player = GetById(id);
        int index = BaseRepository.Players.IndexOf(player);
        BaseRepository.Players.Remove(player);

        BaseRepository.Players.Insert(index, entity);

        return entity;
    }
}
