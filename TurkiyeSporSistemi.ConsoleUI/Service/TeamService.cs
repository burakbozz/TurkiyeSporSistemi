using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurkiyeSporSistemi.ConsoleUI.Model;
using TurkiyeSporSistemi.ConsoleUI.Model.ReturnModels;
using TurkiyeSporSistemi.ConsoleUI.Repository.Concrete;

namespace TurkiyeSporSistemi.ConsoleUI.Service;

public class TeamService : ITeamService
{
    TeamRepository teamRepository = new TeamRepository();
    public ReturnModel<Team> GetById(Guid id)
    {
        try
        {
            Team team = teamRepository.GetById(id);
            return new ReturnModel<Team>
            {
                Data = team,
                Message = "Aradığınız Id ye göre Takım bulundu",
                Success = true,
            };
        }
        catch (Exception ex)
        {
            return new ReturnModel<Team>
            {
                Success = false,
                Message = ex.Message,
                Data = null
            };
        }
    }
}
