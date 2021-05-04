using Area.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Area.Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void TestArea1()
        {
            IFigure triangle = new Triangle(10, 10, 10);

            Assert.AreEqual(43.3, Math.Round(triangle.GetArea(), 1));
        }
        
        [TestMethod]
        public void TestArea2()
        {
            IFigure triangle = new Triangle(25.4, 11.22, 16.18);

            Assert.AreEqual(64, Math.Round(triangle.GetArea(), 1));
        }
        
        [TestMethod]
        public void TestArea3()
        {
            IFigure triangle = new Triangle(18, 6, 22);

            Assert.AreEqual(44.2, Math.Round(triangle.GetArea(), 1));
        }
        
        [TestMethod]
        public void TestArea4()
        {
            IFigure triangle = new Triangle(18, 6, 22);

            Assert.AreEqual(44.2, Math.Round(triangle.GetArea(), 1));
        }

        [TestMethod]
        public void TestArea5()
        {
            IFigure triangle = new Triangle(3, 5, 4);

            Assert.AreEqual(6, Math.Round(triangle.GetArea(), 1));
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Sides must be greater than 0")]
        public void TestExceptions()
        {
            IFigure triangle = new Triangle(-3, 5, 4);
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Triangle doesn't exist")]
        public void TestExceptions1()
        {
            IFigure triangle = new Triangle(21, 10, 10);
        }

        [TestMethod]
        public void TestIsSquare1()
        {
            Triangle triangle = new Triangle(3, 5, 4);

            Assert.AreEqual(true, triangle.IsSquare);
        }

        [TestMethod]
        public void TestIsSquare2()
        {
            Triangle triangle = new Triangle(4, 5, 4);

            Assert.AreEqual(false, triangle.IsSquare);
        }
    }
}
