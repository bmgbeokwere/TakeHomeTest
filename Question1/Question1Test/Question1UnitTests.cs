using Microsoft.VisualStudio.TestTools.UnitTesting;
using Question1;

namespace Question1Test {
    [TestClass]
    public class TriangleUnitTests {
        [TestMethod]
        public void TestIsValid() {
            var triangle = new Triangle(10, 20, 30);
            Assert.IsFalse(triangle.IsValid());
            triangle.Side1 = 10;
            triangle.Side2 = 10;
            triangle.Side3 = 10;
            Assert.IsTrue(triangle.IsValid());
        }

        [TestMethod]
        public void TestGetTriangleType() {
            var triangle = new Triangle(10, 20, 30);
            Assert.AreEqual(triangle.GetTriangleType(), TriangleType.Invalid);
            triangle.Side1 = 10;
            triangle.Side2 = 10;
            triangle.Side3 = 10;
            Assert.AreEqual(triangle.GetTriangleType(), TriangleType.Equilateral);
            triangle.Side1 = 10;
            triangle.Side2 = 10;
            triangle.Side3 = 19;
            Assert.AreEqual(triangle.GetTriangleType(), TriangleType.Isosceles);
            triangle.Side1 = 10;
            triangle.Side2 = 20;
            triangle.Side3 = 19;
            Assert.AreEqual(triangle.GetTriangleType(), TriangleType.Scalene);
        }
    }
}
