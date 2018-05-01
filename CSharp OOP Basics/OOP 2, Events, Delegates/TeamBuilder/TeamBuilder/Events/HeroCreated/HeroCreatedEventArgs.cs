using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamBuilder.Models;

namespace TeamBuilder.Events.HeroCreated
{
	public class HeroCreatedEventArgs : EventArgs
	{
		public Hero Hero { get; set; }
	}
}
