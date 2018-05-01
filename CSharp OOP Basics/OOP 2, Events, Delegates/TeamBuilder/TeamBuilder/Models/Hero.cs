using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TeamBuilder.Models.Enumerations.ModelEnumerations;

namespace TeamBuilder.Models
{
	public abstract class Hero
	{
		public string Name { get; set; }
		public double DPS { get; set; }
		public double Health { get; set; }
		public AbilityResource Resource { get; set; }

		public Hero(string name, double dps, double health)
		{
			this.Name = name;
			this.DPS = dps;
			this.Health = health;
			this.Resource = new AbilityResource(ResourceType.Undefined, 0, 0);
		}

		public sealed class AbilityResource
		{
			public ResourceType Type { get; set; }
			public double MaxCapacity { get; set; }
			public double RegenPerSecond { get; set; }

			public AbilityResource(ResourceType type, double capacity, double regenRate )
			{
				this.Type = type;
				this.MaxCapacity = capacity;
				this.RegenPerSecond = regenRate;
			}
		}
	}
}
