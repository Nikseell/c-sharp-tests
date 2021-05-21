using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Bson;

namespace Exercise1.Tests
{
    [TestClass]
    public class Any15Tests
    {
        private Any15 _target;

        public Any15Tests()
        {
            _target = new Any15();
        }
        [TestMethod]
        public void Has15_ArgumentX15Y5_ReturnsTrue()
        {
            // Act
            var result = _target.Has15(15, 5);

            // Assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Has15_ArgumentX5Y15_ReturnsTrue()
        {
            // Act
            var result = _target.Has15(5, 15);

            // Assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Has15_ArgumentWithoutAny15Given_ReturnsFalse()
        {
            //Act
            var result = _target.Has15(5, 5);

            //Assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Has15_ArgumentX20Y5Difference_ReturnsTrue()
        {
            //Act
            var result = _target.Has15(20, 5);

            //Assert
            Assert.AreEqual(true, result);
        }
    }
}
