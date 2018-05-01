using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TeamBuilder.Models.Hero;

namespace TeamBuilder.Models.Heroes
{
	public class EnergyUser : Hero
	{
		public EnergyUser(string name, double dps, double health, AbilityResource resource) : base(name, dps, health)
		{
			this.Resource = resource;
		}
	}
}
