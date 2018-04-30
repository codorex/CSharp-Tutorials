using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamBuilder.Interfaces;

namespace TeamBuilder.Models
{
  public class Assassin : Hero, IAssassin
  {
    public void Assassinate(Hero hero)
    {
      hero.Health = 0;
    }
  }
}
