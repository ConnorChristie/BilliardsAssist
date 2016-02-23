using System;
using BilliardsAssist.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BilliardsAssist.Tests.Common
{
    [TestClass]
    public class CircularItemTests
    {
        [TestMethod]
        public void Constructor_SetsProperties()
        {
            const double radius = 3;
            const double xOffset = 3;
            const double yOffset = 3;

            var item = new Ball(radius, xOffset, yOffset);

            Assert.AreEqual(radius, item.Radius);
            Assert.AreEqual(xOffset, item.XOffset);
            Assert.AreEqual(yOffset, item.YOffset);
        }
    }
}
