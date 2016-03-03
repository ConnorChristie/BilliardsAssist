using BilliardsAssist.Common.ShapeItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilliardsAssist.Models
{
    /// <summary>
    /// The pool table
    /// </summary>
    public class Table : RectangleItem
    {
        /// <summary>
        /// The balls on the table
        /// </summary>
        public List<Ball> Balls { get; }

        /// <summary>
        /// The table's pockets
        /// </summary>
        public List<Pocket> Pockets { get; }

        public Table(double width, double height, double xOffset, double yOffset)
            : base(width, height, xOffset, yOffset)
        {
            Balls = new List<Ball>();
            Pockets = new List<Pocket>();
        }

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
        public void RemoveBalls()
        {
            Balls.Clear();
        }

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
