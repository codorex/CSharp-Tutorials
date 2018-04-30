using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamBuilder.Interfaces;

namespace TeamBuilder.Models
{
  public class Tank : Hero, ITank
  {
    public void BlockAttack(Hero hero)
    {
      this.Health -= hero.DPS / 8;
    }
  }
}
