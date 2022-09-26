using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ShapeLib;

namespace ShapeLib.test
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void PossibleTriangleZeroSideTest()
        {
            int a = 0;
            int b = 0;
            int c = 0;
            Triangle triangle = new Triangle(a, b, c);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException),
    "The triangle with the given parameters does not exist.")]
        public void PossibleTriangleGreatSideTest()
        {
            int a = 100;
            int b = 4;
            int c = 5;
            Triangle triangle = new Triangle(a, b, c);
        }

        [TestMethod()]
        public void PerimeterTriangleTest()
        {
            int a = 3;
            int b = 4;
            int c = 5;
            Triangle triangle = new Triangle(a, b, c);
            Assert.AreEqual(a + b + c, triangle.Perimeter, 0.001, "correct");
        }
        [TestMethod()]
        public void AreaTriangleTest()
        {
            int a = 3;
            int b = 4;
            int c = 5;
            Triangle triangle = new Triangle(a, b, c);
            Assert.AreEqual(6, triangle.Area(), 0.001, "correct");
        }
        [TestMethod()]
        public void TriangleNameTest()
        {
            int a = 3;
            int b = 4;
            int c = 5;
            Triangle triangle = new Triangle(a, b, c);
            Assert.AreEqual("Right triangle", triangle.ShapeName());
        }
    }
}