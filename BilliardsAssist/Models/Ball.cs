using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BilliardsAssist.Common.ShapeItems;

namespace BilliardsAssist.Models
{
    public class Ball : CircularItem
    {
        public Ball(double radius, double xOffset, double yOffset)
            : base(radius, xOffset, yOffset)
        {
            
        }
    }
}
