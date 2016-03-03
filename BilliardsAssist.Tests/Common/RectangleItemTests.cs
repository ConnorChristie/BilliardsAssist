using System;
using BilliardsAssist.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BilliardsAssist.Tests.Common
{
    [TestClass]
    public class RectangleItemTests
    {
        [TestMethod]
        public void Constructor_SetsProperties()
        {
            const double width = 10;
            const double height = 10;

            const double xOffset = 5;
            const double yOffset = 5;
            
            var item = new Table(width, height, xOffset, yOffset);
            
            Assert.AreEqual(width, item.Width);
            Assert.AreEqual(height, item.Height);
            Assert.AreEqual(xOffset, item.XOffset);
            Assert.AreEqual(yOffset, item.YOffset);
        }
    }
}
