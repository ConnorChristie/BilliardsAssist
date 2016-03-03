using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BilliardsAssist.Engine;
using BilliardsAssist.Interfaces;
using BilliardsAssist.Models;

namespace BilliardsAssist
{
    public class BilliardsAssist
    {
		/// <summary>
		/// The engine that controls the table elements
		/// </summary>
	    public ITableEngine TableEngine { get; }

		/// <summary>
		/// The engine that controls the cue
		/// </summary>
	    public ICueEngine CueEngine { get; }
		
	    public BilliardsAssist(double tableWidth, double tableHeight, double tableXOffset, double tableYOffset,
			double cueWidth, double cueHeight, double cueXOffset, double cueYOffset)
			: this(new Table(tableWidth, tableHeight, tableXOffset, tableYOffset),
				  new Cue(cueWidth, cueHeight, cueXOffset, cueYOffset))
	    { }

	    public BilliardsAssist(Table billiardsTable, Cue cue)
			: this(new TableEngine(billiardsTable), new CueEngine(cue))
	    { }

	    public BilliardsAssist(ITableEngine tableEngine, ICueEngine cueEngine)
	    {
		    TableEngine = tableEngine;
		    CueEngine = cueEngine;
	    }
    }
}
