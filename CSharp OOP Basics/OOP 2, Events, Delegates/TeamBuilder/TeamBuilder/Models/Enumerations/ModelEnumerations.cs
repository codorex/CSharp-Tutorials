using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamBuilder.Models.Enumerations
{
	public static class ModelEnumerations
	{
		public enum ResourceType
		{
			Undefined = 0,
			Mana = 1,
			Health = 2,
			Energy = 3
		}

		public enum TeamRole
		{
			Support = 0,
			DPS = 1,
			Frontline = 2,
			Disabler = 3,
			Flanker = 4
		}
	}
}
