using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BilliardsAssist.Interfaces;
using BilliardsAssist.Models;

namespace BilliardsAssist.Engine
{
	public class BallEngine : IBallEngine
	{
		/// <summary>
		/// The balls on the table
		/// </summary>
		public IList<Ball> Balls { get; } = new List<Ball>();

		/// <summary>
		/// Adds a ball to the table
		/// </summary>
		/// <param name="item"></param>
		public void AddBall(Ball item)
		{
			Balls.Add(item);
		}
		
		/// <summary>
		/// Removes all the balls from the table
		/// </summary>
		public void RemoveAllBalls()
		{
			Balls.Clear();
		}
	}
}
