using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilliardsAssist.Common.ShapeItems
{
    public abstract class RectangleItem : BilliardsItem
    {
        /// <summary>
        /// The width of the item
        /// </summary>
        public double Width { get; }

        /// <summary>
        /// The height of the item
        /// </summary>
        public double Height { get; }

        protected RectangleItem(double width, double height, double xOffset, double yOffset) 
            : base(xOffset, yOffset)
        {
            Width = width;
            Height = height;
        }
    }
}
