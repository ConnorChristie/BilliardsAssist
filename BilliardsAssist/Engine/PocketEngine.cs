using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BilliardsAssist.Interfaces;
using BilliardsAssist.Models;

namespace BilliardsAssist.Engine
{
	public class PocketEngine : IPocketEngine
	{
		/// <summary>
		/// The table's pockets
		/// </summary>
		public IList<Pocket> Pockets { get; } = new List<Pocket>();
		
		/// <summary>
		/// Adds a pocket to the table
		/// </summary>
		/// <param name="item"></param>
		public void AddPocket(Pocket item)
		{
			Pockets.Add(item);
		}
	}
}
