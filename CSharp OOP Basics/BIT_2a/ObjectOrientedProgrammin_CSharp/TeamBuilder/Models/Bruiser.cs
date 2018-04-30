using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamBuilder.Interfaces;

namespace TeamBuilder.Models
{
  public class Bruiser : Hero, ITank
  {
    public void BlockAttack(Hero hero)
    {
      this.Health -= hero.DPS / 3;
    }
  }
}
