using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise2.Tests
{
    [TestClass]
    public class CheckOddEvenTests
    {
        private CheckOddEven _target;

        public CheckOddEvenTests()
        {
            _target = new CheckOddEven();
        }

        [TestMethod]
        public void ArgumentI4_ReturnsTrue()
        {
            // Act
            var result = _target.EvenOrOdd(4);

            // Assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void ArgumentI5_ReturnsFalse()
        {
            // Act
            var result = _target.EvenOrOdd(5);

            // Assert
            Assert.AreEqual(false, result);
        }
    }
}
