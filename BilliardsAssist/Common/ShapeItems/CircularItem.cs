namespace BilliardsAssist.Common.ShapeItems
{
    public abstract class CircularItem : BilliardsItem
    {
        /// <summary>
        /// The radius of the circular item
        /// </summary>
        public double Radius { get; }

        public CircularItem(double radius, double xOffset, double yOffset)
            : base(xOffset, yOffset)
        {
            Radius = radius;
        }
    }
}