using NUnit.Framework;
using System;

namespace TWOA_LW3.Tests
{
    public class Tests
    {
        [Test]
        public void CheckTypeOfTriangle_SidesIsNull_ThrowArgumentNullException() =>
            Assert.Throws<ArgumentNullException>(() => Triangle.CheckTypeOfTriangle(null));

        [TestCase(new int[0])]
        [TestCase(new[] { 5, 3 })]
        [TestCase(new[] { 5, 3, 7, 8 })]
        public void CheckTypeOfTriangle_SidesLengthNotEqualThree_ThrowArgumentException(int[] sides) =>
            Assert.Throws<ArgumentException>(() => Triangle.CheckTypeOfTriangle(sides));

        [TestCase(new[] { 0, 0, 0 })]
        [TestCase(new[] { 0, 3, 5 })]
        [TestCase(new[] { -3, -4, -5 })]
        [TestCase(new[] { -3, -4, 5 })]
        public void CheckTypeOfTriangle_SidesLessThanOrEqualZero_ThrowArgumentOutOfRangeException(int[] sides) =>
            Assert.Throws<ArgumentOutOfRangeException>(() => Triangle.CheckTypeOfTriangle(sides));

        [TestCase(new[] { 1, 6, 8 })]
        [TestCase(new[] { 2, 2, 8 })]
        [TestCase(new[] { 3, 3, 9 })]
        public void CheckTypeOfTriangle_ReturnIncorrect(int[] sides)
        {
            var expectedResult = TriangleType.Incorrect;

            var actualResult = Triangle.CheckTypeOfTriangle(sides);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(new[] { 3, 4, 5 })]
        [TestCase(new[] { 6, 8, 10 })]
        public void CheckTypeOfTriangle_ReturnScalene(int[] sides)
        {
            var expectedResult = TriangleType.Scalene;

            var actualResult = Triangle.CheckTypeOfTriangle(sides);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(new[] { 4, 4, 5 })]
        [TestCase(new[] { 9, 9, 11 })]
        [TestCase(new[] { 12, 14, 14 })]
        public void CheckTypeOfTriangle_ReturnIsosceles(int[] sides)
        {
            var expectedResult = TriangleType.Isosceles;

            var actualResult = Triangle.CheckTypeOfTriangle(sides);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(new[] { 3, 3, 3 })]
        [TestCase(new[] { 4, 4, 4 })]
        [TestCase(new[] { 10, 10, 10 })]
        public void CheckTypeOfTriangle_ReturnEquilateral(int[] sides)
        {
            var expectedResult = TriangleType.Equilateral;

            var actualResult = Triangle.CheckTypeOfTriangle(sides);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}