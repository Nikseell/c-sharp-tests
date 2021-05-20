using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise10.Tests
{
    [TestClass]
    public class GeometryTests
    {
        private Geometry _target;

        public GeometryTests()
        {
            _target = new Geometry();
        }

        [TestMethod]
        public void AreaOfCircleNegativeNumber()
        {
            // Act
            var result = _target.AreaOfCircle(-4);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void AreaOfRectangleNegativeNumber()
        {
            // Act
            var result = _target.AreaOfRectangle(-4, -2);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void AreaOfTriangleNegativeNumber()
        {
            // Act
            var result = _target.AreaOfTriangle(-3, -6);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void AreaOfCirclePositiveNumber()
        {
            // Act
            var result = _target.AreaOfCircle(3);

            // Assert
            Assert.AreEqual(28.27, result);
        }

        [TestMethod]
        public void AreaOfRectanglePositiveNumbers()
        {
            // Act
            var result = _target.AreaOfRectangle(4, 5);

            // Assert
            Assert.AreEqual(20, result);
        }

        [TestMethod]
        public void AreaOfTrianglePositiveNumbers()
        {
            // Act
            var result = _target.AreaOfTriangle(4, 2);

            // Assert
            Assert.AreEqual(4, result);
        }
    }
}
