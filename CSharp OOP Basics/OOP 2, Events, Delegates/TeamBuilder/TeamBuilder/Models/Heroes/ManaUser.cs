using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TeamBuilder.Models.Enumerations.ModelEnumerations;

namespace TeamBuilder.Models.Heroes
{
	public class ManaUser : Hero
	{
		public ManaUser(string name, double dps, double health, AbilityResource resource) : base(name, dps, health)
		{
			this.Resource = resource;
		}
	}
}
