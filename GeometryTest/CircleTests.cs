using GeometryCalculator.Models;

namespace GeometryTest
{
    [TestClass]
    public class CircleTests
    {

        [TestMethod]
        public void AreaIsCorrectWithRadiusIsPositive()
        {
            const double EXPECTED_RADIUS_VALUE = 314.16;

            double area = Circle.GetArea(10);

            Assert.AreEqual(EXPECTED_RADIUS_VALUE, area);
        }

        [TestMethod]
        //Также вместо Assert можно использовать атрибут [ExpectedException]
        public void GetExceptionWhenRadiusIsNegative()
        {
            Assert.ThrowsException<Exception>(() => Circle.GetArea(-5));
        }

        [TestMethod]
        public void GetExceptionWhenRadiusIsZero()
        {
            Assert.ThrowsException<Exception>(() => Circle.GetArea(0));
        }
    }
}