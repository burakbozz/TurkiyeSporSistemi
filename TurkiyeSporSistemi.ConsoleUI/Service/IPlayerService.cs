
using TurkiyeSporSistemi.ConsoleUI.Model.ReturnModels;
using TurkiyeSporSistemi.ConsoleUI.Model;

namespace TurkiyeSporSistemi.ConsoleUI.Service;

public interface IPlayerService
{
    ReturnModel<Player> GetById(int id);

    ReturnModel<Player> Update(int id ,Player updated);
}
