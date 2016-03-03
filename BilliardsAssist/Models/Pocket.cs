using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BilliardsAssist.Common.ShapeItems;

namespace BilliardsAssist.Models
{
    public class Pocket : CircularItem
    {
        public Pocket(double radius, double xOffset, double yOffset) 
            : base(radius, xOffset, yOffset)
        {

        }
    }
}
