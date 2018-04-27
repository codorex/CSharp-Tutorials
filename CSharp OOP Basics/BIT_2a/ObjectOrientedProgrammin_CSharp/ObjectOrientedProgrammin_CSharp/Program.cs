using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgrammin_CSharp
{
  public class Program
  {
    static void Main(string[] args)
    {
      TeamMember ronaldo = new TeamMember(7, 97, "Christiano Ronaldo", "RW");
      TeamMember rooney = new TeamMember(10, 94, "Wayne Rooney", "ATK");

      FootballTeam manUtd = new FootballTeam("Manchester United");
      manUtd.AddMember(ronaldo);
      manUtd.AddMember(rooney);

      TeamMember strongestMember = manUtd.CompareMembers(ronaldo, rooney);
      manUtd.RemoveMember(ronaldo);
    }
  }
}
