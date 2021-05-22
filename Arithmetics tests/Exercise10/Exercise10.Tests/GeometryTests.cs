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
        public void AreaOfCircle_ArgumentIsNegativeNumber_Returns0()
        {
            // Act
            var result = _target.AreaOfCircle(-4);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void AreaOfRectangle_ArgumentsAreNegativeNumbers_Returns0()
        {
            // Act
            var result = _target.AreaOfRectangle(-4, -2);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void AreaOfTriangle_ArgumentsAreNegativeNumbers_Returns0()
        {
            // Act
            var result = _target.AreaOfTriangle(-3, -6);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void AreaOfCircle_ArgumentIsPositiveNumber_ReturnsResult()
        {
            // Act
            var result = _target.AreaOfCircle(3);

            // Assert
            Assert.AreEqual(28.27, result);
        }

        [TestMethod]
        public void AreaOfRectangle_ArgumentsArePositiveNumbers_ReturnsResult()
        {
            // Act
            var result = _target.AreaOfRectangle(4, 5);

            // Assert
            Assert.AreEqual(20, result);
        }

        [TestMethod]
        public void AreaOfTriangle_ArgumentsArePositiveNumbers_ReturnsResult()
        {
            // Act
            var result = _target.AreaOfTriangle(4, 2);

            // Assert
            Assert.AreEqual(4, result);
        }
    }
}
