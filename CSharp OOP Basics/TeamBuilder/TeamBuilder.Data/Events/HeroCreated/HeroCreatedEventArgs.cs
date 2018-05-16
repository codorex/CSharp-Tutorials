using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamBuilder.Data.Models.Hero;

namespace TeamBuilder.Data.Events.HeroCreated
{
    public class HeroCreatedEventArgs : EventArgs
    {
        public Hero Hero { get; set; }
        public DateTime DateCreated { get; set; }
        public double MaximumResource { get; set; }

        public HeroCreatedEventArgs(Hero hero, DateTime dateCreated, double maxResource)
        {
            this.Hero = hero;
            this.DateCreated = dateCreated;
            this.MaximumResource = maxResource;
        }
    }
}
