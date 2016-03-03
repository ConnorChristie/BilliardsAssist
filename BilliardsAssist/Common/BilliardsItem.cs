using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilliardsAssist.Common
{
    public abstract class BilliardsItem
    {
        public double XOffset { get; set; }

        public double YOffset { get; set; }

        protected BilliardsItem(double xOffset, double yOffset)
        {
            XOffset = xOffset;
            YOffset = yOffset;
        }
    }
}
