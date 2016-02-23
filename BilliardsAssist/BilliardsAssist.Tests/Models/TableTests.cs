using System;
using BilliardsAssist.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BilliardsAssist.Tests.Models
{
    [TestClass]
    public class TableTests
    {
        [TestMethod]
        public void AddBall_GetsAdded()
        {
            var table = new Table(10, 10, 5, 5);
            var ball = new Ball(3, 4, 4);
            
            table.AddBall(ball);

            Assert.AreEqual(1, table.Balls.Count);
        }

        [TestMethod]
        public void RemoveBalls_RemovesAllBalls()
        {
            var table = new Table(10, 10, 5, 5);

            var item1 = new Ball(3, 4, 4);
            var item2 = new Ball(2, 3, 3);

            table.AddBall(item1);
            table.AddBall(item2);
            
            Assert.AreEqual(2, table.Balls.Count);

            table.RemoveBalls();

            Assert.AreEqual(0, table.Balls.Count);
        }

        [TestMethod]
        public void AddPocket_GetsAdded()
        {
            var table = new Table(10, 10, 5, 5);
            var item = new Pocket(3, 4, 4);

            table.AddPocket(item);

            Assert.AreEqual(1, table.Pockets.Count);
        }
    }
}
