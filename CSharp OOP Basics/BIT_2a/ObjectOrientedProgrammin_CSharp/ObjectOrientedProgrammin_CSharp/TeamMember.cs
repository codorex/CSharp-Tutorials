using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgrammin_CSharp
{
  public class TeamMember
  {
    public int Number { get; set; }
    public int Overall { get; set; }
    public string Name { get; set; }
    public string Position { get; set; }

    public TeamMember(int number, int overall, string name, string position)
    {
      this.Number = number;
      this.Overall = overall;
      this.Name = name;
      this.Position = position;
    }
  }
}
