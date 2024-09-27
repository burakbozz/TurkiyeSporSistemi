﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurkiyeSporSistemi.ConsoleUI.Model;

namespace TurkiyeSporSistemi.ConsoleUI.Repository;

public static class BaseRepository
{


    public static List<Team> Teams = new List<Team>()
        {
            new Team()
            {
                Id = new Guid("{4C7E274B-6A4F-4697-9761-E16E7D26EBF5}"),
                Name = "TRABZONSPOR",
                Description = "Trabzonspor Açıklaması",
                Since = new DateTime(1967,1,4)
            },
            new Team()
            {
                Id = Guid.NewGuid(),
                Name = "fenerbahce",
                Description= "Şikebahçe",
                Since = new DateTime(1907,7,7)
            }
        };

    public static List<Player> Players = new List<Player>()
        {
            new Player
            {
                Id = 1,
                Name="Okay",
                Surname = "Yokuşlu",
                Branch = "Futbol",
                MarketValue = 1000000,
                Number = "5",
                Position = "Defansif Orta Saha",
                TeamId = new Guid("{4C7E274B-6A4F-4697-9761-E16E7D26EBF5}")
            },
            new Player
            {
                Id= 2,
                Name = "Atilla",
                Surname = "Karaoğlan",
                Branch = "Futbol",
                MarketValue = 100000,
                Number = "99",
                Position = "Forvet",
                TeamId = new Guid("{D243A789-1884-4AB0-A4B0-E355575020ED}")
            }

        };

}
