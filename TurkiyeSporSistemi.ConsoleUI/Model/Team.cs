﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurkiyeSporSistemi.ConsoleUI.Model;

public class Team : Entity<Guid>
{
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime Since { get; set; }

    public override string ToString()
    {
        return $"{Name}";
    }
}
