using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamBuilder.Data.Enumerations;
using TeamBuilder.Data.Models.Hero;

namespace TeamBuilder.Data.Exceptions.Args
{
    public class TeamRoleTakenExceptionArgs
    {
        public TeamRole Role { get; }
        public Hero Occupant { get; }

        public TeamRoleTakenExceptionArgs(TeamRole role, Hero occupant)
        {
            this.Role = role;
            this.Occupant = occupant;
        }
    }
}
