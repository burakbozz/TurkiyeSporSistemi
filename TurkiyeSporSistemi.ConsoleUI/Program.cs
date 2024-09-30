

using TurkiyeSporSistemi.ConsoleUI.Model;
using TurkiyeSporSistemi.ConsoleUI.Service;


PlayerService playerService = new PlayerService();
//Console.WriteLine(playerService.GetById(1));

TeamService teamService = new TeamService();
//Console.WriteLine(teamService.GetById(new Guid("{4C7E274B-6A4F-4697-9761-E16E7D26EBF5}")));

Player updated  = new Player
{
    Id = 2,
    Name = "Edin",
    Surname = "Dzeko",
    Branch = "Futbol",
    MarketValue = 100000,
    Number = "99",
    Position = "Forvet",
    TeamId = new Guid("{D243A789-1884-4AB0-A4B0-E355575020ED}")
};

Player updated2 = new Player
{
    Id = 2,
    Name = "",
    Surname = "Dzeko",
    Branch = "Futbol",
    MarketValue = 100000,
    Number = "99",
    Position = "Forvet",
    TeamId = new Guid("{D243A789-1884-4AB0-A4B0-E355575020ED}")
};

Team updatedTeam = new Team
{
    Id = new Guid("{4C7E274B-6A4F-4697-9761-E16E7D26EBF5}"),
    Name = "",
    Description = "Trabzonspor Açıklaması",
    Since = new DateTime(1967, 1, 4)
};
Team updatedTeam2 = new Team
{
    Id = new Guid("{4C7E274B-6A4F-4697-9761-E16E7D26EBF5}"),
    Name = "Galatasaray",
    Description = "Trabzonspor Açıklaması",
    Since = new DateTime(1967, 1, 4)
};

Console.WriteLine(teamService.Update(new Guid("{4C7E274B-6A4F-4697-9761-E16E7D26EBF5}"),updatedTeam));
Console.WriteLine("--------------------------------------");
Console.WriteLine(teamService.Update(new Guid("{5C7E274B-6A4F-4697-9761-E16E7D26EBF5}"), updatedTeam2));

Console.WriteLine("--------------------------------------");
Console.WriteLine(playerService.Update(2, updated2));
Console.WriteLine("--------------------------------------");
Console.WriteLine(playerService.Update(3, updated));


