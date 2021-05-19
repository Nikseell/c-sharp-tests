using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise6.Tests
{
    [TestClass]
    public class CozaLozaWozaTests
    {
        private CozaLozaWoza _target;

        public CozaLozaWozaTests()
        {
            _target = new CozaLozaWoza();
        }

        [TestMethod]
        public void ArgumentY3_ReturnsCoza()
        {
            // Act
            var result = _target.CozaLozaWozaProgram(3);

            // Assert
            Assert.AreEqual("Coza", result);
        }

        [TestMethod]
        public void ArgumentY5_ReturnsLoza()
        {
            // Act
            var result = _target.CozaLozaWozaProgram(5);

            // Assert
            Assert.AreEqual("Loza", result);
        }

        [TestMethod]
        public void ArgumentY7_ReturnsWoza()
        {
            // Act
            var result = _target.CozaLozaWozaProgram(7);

            // Assert
            Assert.AreEqual("Woza", result);
        }

        [TestMethod]
        public void ArgumentY1_ReturnsNumber()
        {
            // Act
            var result = _target.CozaLozaWozaProgram(1);

            // Assert
            Assert.AreEqual("1", result);
        }

        [TestMethod]
        public void ArgumentY1_ReturnsCozaWoza()
        {
            // Act
            var result1 = _target.CozaLozaWozaProgram(3);
            var result2 = _target.CozaLozaWozaProgram(5);
            var result = result1 + result2;

            // Assert
            Assert.AreEqual("CozaLoza", result);
        }

        [TestMethod]
        public void ArgumentYOverLimit_ReturnsNull()
        {
            // Act
            var result = _target.CozaLozaWozaProgram(111);

            // Assert
            Assert.AreEqual(null, result);
        }
    }
}
