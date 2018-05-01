using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamBuilder.Models.Heroes
{
	public class HealthUser : Hero
	{
		public HealthUser(string name, double dps, double health, AbilityResource resource) : base(name, dps, health)
		{
			this.Resource = resource;
		}
	}
}
