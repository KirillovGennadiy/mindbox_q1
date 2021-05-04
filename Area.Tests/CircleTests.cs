using Area.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Area.Tests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void GetCircleArea1()
        {
            IFigure circle = new Circle(10);
                
            Assert.AreEqual(314.2, Math.Round(circle.GetArea(), 1));
        }

        [TestMethod]
        public void GetCircleArea2()
        {
            IFigure circle = new Circle(25.4);

            Assert.AreEqual(2026.8, Math.Round(circle.GetArea(), 1));
        }

        [TestMethod]
        public void GetCircleArea3()
        {
            IFigure circle = new Circle(18);

            Assert.AreEqual(1017.9, Math.Round(circle.GetArea(), 1));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Radius must be greater than 0")]
        public void TestExceptions()
        {
            IFigure circle = new Circle(-18);
        }

    }
}
