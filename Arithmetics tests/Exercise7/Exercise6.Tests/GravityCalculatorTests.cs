using Exercise7;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise6.Tests
{
    [TestClass]
    public class GravityCalculatorTests
    {
        private GravityCalculator _target;

        public GravityCalculatorTests()
        {
            _target = new GravityCalculator();
        }

        [TestMethod]
        public void ArgumentX10()
        {
            // Act
            var result = _target.GravityCalculatorFormula(10.0);

            // Assert
            Assert.AreEqual(-490.5, result);
        }

        [TestMethod]
        public void ArgumentXNegative()
        {
            // Act
            var result = _target.GravityCalculatorFormula(-4);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void ArgumentX0()
        {
            // Act
            var result = _target.GravityCalculatorFormula(0);

            // Assert
            Assert.AreEqual(0, result);
        }
    }
}
