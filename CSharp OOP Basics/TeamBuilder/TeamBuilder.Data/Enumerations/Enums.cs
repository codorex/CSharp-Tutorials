using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamBuilder.Data.Enumerations
{
    public enum ResourceType
    {
        Unassigned = 0,
        Mana = 1,
        Energy = 2,
        Health = 3
    }

    public enum TeamRole
    {
        Frontline = 0,
        DPS = 1,
        Support = 2,
        Flanker = 3,
        Marksman = 4
    }
}
