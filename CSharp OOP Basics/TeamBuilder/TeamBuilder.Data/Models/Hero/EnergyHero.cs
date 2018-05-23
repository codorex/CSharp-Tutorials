﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamBuilder.Data.Models.Hero
{
    public class EnergyHero : Hero
    {
        public EnergyHero(string name, double dps, double health, AbilityResource resource) : base(name, dps, health)
        {
            this.Resource = resource;
        }
    }
}