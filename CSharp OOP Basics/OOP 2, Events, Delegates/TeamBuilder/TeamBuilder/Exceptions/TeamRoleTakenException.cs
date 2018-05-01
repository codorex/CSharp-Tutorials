using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamBuilder.Models;
using static TeamBuilder.Models.Enumerations.ModelEnumerations;

namespace TeamBuilder.Exceptions
{
	public class TeamRoleTakenException : Exception
	{
		public TeamRole Role { get; set; }
		public Hero Occupant { get; set; }

		public TeamRoleTakenException(TeamRole role, Hero occupant, string message = "") : base(message)
		{
			this.Role = role;
			this.Occupant = occupant;
		}
	}
}
