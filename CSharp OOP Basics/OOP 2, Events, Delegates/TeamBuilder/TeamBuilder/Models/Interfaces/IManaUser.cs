using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamBuilder.Models.Interfaces
{
	public interface IManaUser
	{
		void SetManaResource(double maximumMana, double regenPerSecond);
	}
}
