using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BilliardsAssist.Common.ShapeItems;

namespace BilliardsAssist.Models
{
    public class Cue : RectangleItem
    {
        public Cue(double width, double height, double xOffset, double yOffset) 
            : base(width, height, xOffset, yOffset)
        {

        }
    }
}
