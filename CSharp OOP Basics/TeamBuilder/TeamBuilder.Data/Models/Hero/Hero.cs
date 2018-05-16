using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TeamBuilder.Data.Enumerations;

namespace TeamBuilder.Data.Models.Hero
{
    public abstract class Hero
    {
        public double Health { get; set; }
        public double DPS { get; set; }
        public string Name { get; set; }
        public AbilityResource Resource { get; set; }

        public Hero(string name, double dps, double health)
        {
            this.Name = name;
            this.DPS = dps;
            this.Health = health;
            this.Resource = new AbilityResource(ResourceType.Unassigned, 0, 0);
        }

        public sealed class AbilityResource
        {
            public ResourceType Type { get; set; }
            public double MaximumCapacity { get; set; }
            public double RegenRate { get; set; }

            public AbilityResource(ResourceType resourceType, double capacity, double regenRate)
            {
                this.Type = resourceType;
                this.MaximumCapacity = capacity;
                this.RegenRate = regenRate;
            }
        }
    }
}
