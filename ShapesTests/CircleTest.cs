using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ShapeLib;

namespace ShapeLib.test
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod()]
        public void AreaCircleTest()
        {
            int radius = 2;
            Circle circle = new Circle(radius);
            Assert.AreEqual(12.566, circle.Area(), 0.001, "correct");
        }
        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void PossibleCircleZeroRadiusTest()
        {
            int radius = 0;
            Circle circle = new Circle(radius);
        }
    }
}
