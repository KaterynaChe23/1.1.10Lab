using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace lab1v10.Tests
{
    [TestClass]
    public class EquationOfThePlaneTests
    {
        [TestMethod]
        public void Constructor_ShouldInitializeCoefficients()
        {
            double a = 6, b = -5, c = -9.3, d = 11;
            EquationOfThePlane plane = new EquationOfThePlane(a, b, c, d);

            Assert.AreEqual(a, plane[0]);
            Assert.AreEqual(b, plane[1]);
            Assert.AreEqual(c, plane[2]);
            Assert.AreEqual(d, plane[3]);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Indexer_ShouldThrowException_ForInvalidIndex_Get()
        {
            double a = 6, b = -5, c = -9.3, d = 11;
            EquationOfThePlane plane = new EquationOfThePlane(a, b, c, d);

            var value = plane[4];
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Indexer_ShouldThrowException_ForInvalidIndex_Set()
        {
            double a = 6, b = -5, c = -9.3, d = 11;
            EquationOfThePlane plane = new EquationOfThePlane(a, b, c, d);

            plane[4] = 1;
        }

        [TestMethod]
        public void TestIntersectionWithXAxes()
        {
            EquationOfThePlane plane = new EquationOfThePlane(2, 3, -4, 5);

            double result = plane.Coordinates(0);

            double expected = -2.5;

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestIntersectionWithYAxisOnly()
        {

            EquationOfThePlane plane = new EquationOfThePlane(2, 3, -4, 5);

            double result = plane.Coordinates(1);

            double expected = -1.6666666666666667;

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestIntersectionWithZAxisOnly()
        {

            EquationOfThePlane plane = new EquationOfThePlane(2, 3, -4, 5);

            double result = plane.Coordinates(2);

            double expected = 1.25;

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestCoordinatesX()
        {
            EquationOfThePlane result = new EquationOfThePlane(0, 3, -4, 5);
            Assert.ThrowsException<System.Exception>(() => result.Coordinates(0));

        }

        [TestMethod]
        public void TestCoordinatesY()
        {
            EquationOfThePlane result = new EquationOfThePlane(7, 0, -4, 5);
            Assert.ThrowsException<System.Exception>(() => result.Coordinates(1));

        }

        [TestMethod]
        public void TestCoordinatesZ()
        {
            EquationOfThePlane result = new EquationOfThePlane(9, 3, 0, 5);
            Assert.ThrowsException<System.Exception>(() => result.Coordinates(2));

        }
        [TestMethod]
        public void TestCoordinates_OutOfSize()
        {
            EquationOfThePlane result = new EquationOfThePlane(9, 3, 0, 5);
            Assert.ThrowsException<System.Exception>(() => result.Coordinates(3));

        }
        [TestMethod]
        public void IsPointOnPlane_ShouldReturnTrue_WhenPointIsOnPlane()
        {
            EquationOfThePlane plane = new EquationOfThePlane(6, -5, -9.3, 11);
            double x = 0, y = 0, z = 1.182795698924731;

            bool result = plane.IsPointOnPlane(x, y, z);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsPointOnPlane_ShouldReturnFalse_WhenPointIsNotOnPlane()
        {
            EquationOfThePlane plane = new EquationOfThePlane(6, -5, -9.3, 11);
            double x = 1, y = 2, z = 3;

            bool result = plane.IsPointOnPlane(x, y, z);

            Assert.IsFalse(result);
        }
    }
}
