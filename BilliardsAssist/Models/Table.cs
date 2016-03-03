using BilliardsAssist.Common.ShapeItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BilliardsAssist.Engine;

namespace BilliardsAssist.Models
{
    /// <summary>
    /// The pool table
    /// </summary>
    public class Table : RectangleItem
    {
		/// <summary>
		/// The engine for the balls on the table
		/// </summary>
		public BallEngine BallEngine { get; }

        /// <summary>
        /// The engine for the pockets on the table
        /// </summary>
        public PocketEngine PocketEngine { get; }

        public Table(double width, double height, double xOffset, double yOffset)
            : base(width, height, xOffset, yOffset)
        {
			BallEngine = new BallEngine();
			PocketEngine = new PocketEngine();
        }
    }
}
