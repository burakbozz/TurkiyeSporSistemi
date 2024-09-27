using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurkiyeSporSistemi.ConsoleUI.Model.ReturnModels;
using TurkiyeSporSistemi.ConsoleUI.Model;

namespace TurkiyeSporSistemi.ConsoleUI.Service;

public interface IPlayerService
{
    ReturnModel<Player> GetById(int id);
}
