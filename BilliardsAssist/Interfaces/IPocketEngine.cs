using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BilliardsAssist.Models;

namespace BilliardsAssist.Interfaces
{
	public interface IPocketEngine
	{
		IList<Pocket> Pockets { get; }

		void AddPocket(Pocket pocket);
	}
}
