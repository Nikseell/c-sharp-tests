using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise5.Tests
{
    [TestClass]
    public class HappyNumberTests
    {
        private HappyNumber _target;

        public HappyNumberTests()
        {
            _target = new HappyNumber();
        }

        [TestMethod]
        public void CorrectlyMakesNumbersIntoDigets()
        {
            // Act
            var result = _target.ToDigets(139);
            var res = new List<int> {1, 3, 9};

            // Assert
            CollectionAssert.AreEqual(res, result);
        }

        [TestMethod]
        public void CorrectlyMakesNumberIntoDigets()
        {
            // Act
            var result = _target.ToDigets(4);
            var res = new List<int> { 4 };

            // Assert
            CollectionAssert.AreEqual(res, result);
        }

        [TestMethod]
        public void FormulaIsCorrect()
        {
            // Act
            var res = new List<int> { 1, 3, 9 };
            var result = _target.Calc(res);

            // Assert
            Assert.AreEqual(91, result);
        }

        [TestMethod]
        public void HappyNumber()
        {
            // Act
            var result = _target.IsHappy(139);

            // Assert
            Assert.AreEqual("Happy number!", result);
        }

        [TestMethod]
        public void NotHappyNumber()
        {
            // Act
            var result = _target.IsHappy(4);

            // Assert
            Assert.AreEqual("Not happy!", result);
        }
    }
}
