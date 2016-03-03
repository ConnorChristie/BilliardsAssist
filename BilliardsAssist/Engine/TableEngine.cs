using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BilliardsAssist.Interfaces;
using BilliardsAssist.Models;

namespace BilliardsAssist.Engine
{
	public class TableEngine : ITableEngine
	{
		/// <summary>
		/// The billiards table
		/// </summary>
		public Table BilliardsTable { get; }
		
		public TableEngine(Table billiardsTable)
		{
			BilliardsTable = billiardsTable;
		}
	}
}
