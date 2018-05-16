using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamBuilder.Data.Enumerations;
using TeamBuilder.Data.Exceptions.Args;
using TeamBuilder.Data.Models.Hero;

namespace TeamBuilder.Data.Exceptions
{
    public class TeamRoleTakenException : Exception
    {
        public TeamRoleTakenExceptionArgs Args { get; }

        public TeamRoleTakenException(TeamRoleTakenExceptionArgs args)
        {
            this.Args = args;
        }
    }
}
