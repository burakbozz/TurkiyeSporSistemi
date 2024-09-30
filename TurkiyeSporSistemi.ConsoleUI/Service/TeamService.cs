
using System.Net;
using TurkiyeSporSistemi.ConsoleUI.Exceptions;
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

    public ReturnModel<Team> Update(Guid id, Team updated)
    {
        try
        {
            CheckTeamName(updated.Name);
            Team team = teamRepository.Update(id, updated);

            return new ReturnModel<Team>
            {
                Data = team,
                Message = "takım güncellendi",
                Success = true,
                StatusCode = HttpStatusCode.OK
            };
        }
        catch (NotFoundException ex)
        {
            return ReturnModelOfException(ex);
        }
        catch (ValidationException ex)
        {
            return ReturnModelOfException(ex);
        }
    }


    private void CheckTeamName(string name)
    {
        if (name.Length < 1)
        {
            throw new ValidationException("takım ismi minimum 1 karakterli olmalıdır.");
        }
    }

    private ReturnModel<Team> ReturnModelOfException(Exception ex)
    {
        if (ex.GetType() == typeof(NotFoundException))
        {
            return new ReturnModel<Team>
            {
                Data = null,
                Message = ex.Message,
                Success = false,
                StatusCode = HttpStatusCode.NotFound
            };
        }

        if (ex.GetType() == typeof(ValidationException))
        {
            return new ReturnModel<Team>
            {
                Data = null,
                Message = ex.Message,
                Success = false,
                StatusCode = HttpStatusCode.BadRequest
            };
        }


        return new ReturnModel<Team>
        {
            Data = null,
            Message = ex.Message,
            Success = false,
            StatusCode = HttpStatusCode.InternalServerError
        };
    }
}
