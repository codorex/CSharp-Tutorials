using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamBuilder.Data.Enumerations;
using TeamBuilder.Data.Exceptions;
using TeamBuilder.Data.Models.Hero;
using TeamBuilder.Data.Exceptions.Args;

namespace TeamBuilder.Data
{
    public class Builder
    {
        public Dictionary<TeamRole, Hero> TeamSlots { get; set; }

        public void Enlist(Hero hero, TeamRole role)
        {
            if (this.TeamSlots.ContainsKey(role) && this.TeamSlots[role] is null)
            {
                throw new TeamRoleTakenException(new TeamRoleTakenExceptionArgs(role, hero));
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
