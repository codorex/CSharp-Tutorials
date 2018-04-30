using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamBuilder.Interfaces;

namespace TeamBuilder.Models
{
  public class Hero : BaseHero, IMagicHero
  {
    public void Attack(Hero hero)
    {
      hero.Health -= this.DPS;
    }

    public void AttackWithMagic(Hero hero)
    {
      hero.Health -= (int)(this.DPS * 1.5);
    }
  }
}
