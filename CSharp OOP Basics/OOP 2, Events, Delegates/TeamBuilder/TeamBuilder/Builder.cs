using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamBuilder.Exceptions;
using TeamBuilder.Models;
using static TeamBuilder.Models.Enumerations.ModelEnumerations;

namespace TeamBuilder
{
	public class Builder
	{
		public Dictionary<TeamRole, Hero> TeamSlots { get; private set; }

		public Builder()
		{
			this.TeamSlots = new Dictionary<TeamRole, Hero>();
		}

		public void Enlist(Hero hero, TeamRole role)
		{
			if (this.TeamSlots.ContainsKey(role))
			{
				throw new TeamRoleTakenException(role, this.GetHeroByRole(role), "Role is already taken");
			}
			else
			{
				this.TeamSlots.Add(role, hero);
			}
		}

		public Hero GetHeroByRole(TeamRole role)
		{
			return this.TeamSlots.ContainsKey(role) ? this.TeamSlots[role] : null;
		}
	}
}
