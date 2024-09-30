
using TurkiyeSporSistemi.ConsoleUI.Model.ReturnModels;
using TurkiyeSporSistemi.ConsoleUI.Model;

namespace TurkiyeSporSistemi.ConsoleUI.Service;

public interface ITeamService
{
    ReturnModel<Team> GetById(Guid id);

    ReturnModel<Team> Update(Guid id, Team updated);
}
