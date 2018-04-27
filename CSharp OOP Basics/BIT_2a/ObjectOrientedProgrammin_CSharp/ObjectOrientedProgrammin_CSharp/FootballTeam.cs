using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgrammin_CSharp
{
  public class FootballTeam
  {
    public string Name { get; set; }
    public List<TeamMember> Members { get; set; }

    public FootballTeam(string name)
    {
      this.Name = name;
      this.Members = new List<TeamMember>();
    }

    public void AddMember(TeamMember member)
    {
      this.Members.Add(member);
    }

    public TeamMember CompareMembers(TeamMember member1, TeamMember member2)
    {
      if (member1.Overall > member2.Overall)
      {
        return member1;
      }

      return member2;
    }

    public void RemoveMember(TeamMember member)
    {
      if (this.Members.Contains(member))
      {
        this.Members.Remove(member);
      }
    }
  }
}
