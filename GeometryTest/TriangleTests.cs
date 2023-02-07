using GeometryCalculator.Models;

namespace GeometryTest
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void AreaIsCorrectWhenTriangleIsRight()
        {
            const double CORRECT_TRIANGLE_AREA = 6;

            Triangle testTriangle = new Triangle(3, 4, 5);

            Assert.AreEqual(CORRECT_TRIANGLE_AREA, testTriangle.Area);
        }

        [TestMethod]
        public void AreaIsCorrectWhenTriangleIsNotRight()
        {
            const double CORRECT_TRIANGLE_AREA = 7.64;

            Triangle testTriangle = new Triangle(3, 6, 8);

            Assert.AreEqual(CORRECT_TRIANGLE_AREA, testTriangle.Area);
        }

        [TestMethod]
        public void GetExceptionWhenTriangleDoesntExist()
        {
            Assert.ThrowsException<Exception>(() => new Triangle(2, 1, 1));
        }

    }
}
