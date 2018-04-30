using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamBuilder.Models;

namespace TeamBuilder
{
  public class Builder
  {
    public Dictionary<string, Hero> Heroes { get; set; }

    public void Enlist(Hero hero, string role)
    {
      if (Heroes.ContainsKey(role))
      {
        throw new Exception("Role is already taken.");
      }

      Heroes.Add(role, hero);
    }

    public Builder()
    {
      this.Heroes = new Dictionary<string, Hero>();
    }
  }
}
