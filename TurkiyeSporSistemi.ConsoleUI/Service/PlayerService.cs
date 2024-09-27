using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurkiyeSporSistemi.ConsoleUI.Model.ReturnModels;
using TurkiyeSporSistemi.ConsoleUI.Model;
using TurkiyeSporSistemi.ConsoleUI.Repository.Concrete;

namespace TurkiyeSporSistemi.ConsoleUI.Service;

public class PlayerService : IPlayerService
{

    PlayerRepository playerRepository = new PlayerRepository();
    public ReturnModel<Player> GetById(int id)
    {
        try
        {
            Player player = playerRepository.GetById(id);
            return new ReturnModel<Player>
            {
                Data = player,
                Message = "Aradığınız Id ye göre Oyuncu bulundu",
                Success = true,
            };
        }
        catch (Exception ex)
        {
            return new ReturnModel<Player>
            {
                Success = false,
                Message = ex.Message,
                Data = null
            };
        }
    }
}