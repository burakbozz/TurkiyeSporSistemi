

using TurkiyeSporSistemi.ConsoleUI.Service;


PlayerService playerService = new PlayerService();
Console.WriteLine(playerService.GetById(1));

TeamService teamService = new TeamService();
Console.WriteLine(teamService.GetById(new Guid("{4C7E274B-6A4F-4697-9761-E16E7D26EBF5}")));