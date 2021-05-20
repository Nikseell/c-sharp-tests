using System.Linq;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise6.Tests
{
    [TestClass]
    public class ReplaceLastArrayElementTests
    {
        private ReplaceLastArrayElement _target;
        public ReplaceLastArrayElementTests()
        {
            _target = new ReplaceLastArrayElement();
        }
        [TestMethod]
        public void CheckArraySize()
        {
            // Act
            var result = _target.MakeArray().Length;

            // Assert
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void IsLastNumberChanged()
        {
            //Act
            var result = _target.ReplaceLastElement().Last();

            //Assert
            Assert.AreEqual(-7,result);
        }
    }
}
