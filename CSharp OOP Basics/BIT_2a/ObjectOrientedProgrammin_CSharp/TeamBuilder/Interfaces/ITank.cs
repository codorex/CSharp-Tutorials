using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamBuilder.Models;

namespace TeamBuilder.Interfaces
{
  public interface ITank
  {
    void BlockAttack(Hero hero);
  }
}
