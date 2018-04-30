using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamBuilder.Models
{
  public abstract class BaseHero
  {
    public int DPS { get; set; }
    public string Name { get; set; }
    public int Health { get; set; }
    public int Mana { get; set; }
  }
}
