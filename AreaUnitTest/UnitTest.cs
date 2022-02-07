using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using AreaLibrary;

namespace AreaUnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void RadiusIsNull()
        {
            Circle c = new Circle(0);
            Assert.AreEqual(0, c.GetArea());
        }
        [TestMethod]
        public void EmptyArrayOfSides()
        {
            double[] array = new double[3];
            Triangle t = new Triangle(array);
            Assert.AreEqual(0, t.GetArea());
        }
        [TestMethod]
        public void IsRightTriangle()
        {
            double[] array = { 3, 4, 5 };
            Triangle t = new Triangle(array);
            Assert.IsTrue(t.IsRight());
        }
    }
}
