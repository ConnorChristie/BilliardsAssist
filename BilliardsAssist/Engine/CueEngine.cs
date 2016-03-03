using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BilliardsAssist.Interfaces;
using BilliardsAssist.Models;

namespace BilliardsAssist.Engine
{
	public class CueEngine : ICueEngine
	{
		public Cue Cue { get; }

		public CueEngine(Cue cue)
		{
			Cue = cue;
		}
	}
}
