using DragRace;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise1.Tests
{
    [TestClass]
    public class TeslaTests
    {
        [TestMethod]
        public void SpeedUp_Tesla_ReturnsSpeedUpTwoTimes()
        {
            // Arrange
            ICar tesla = new Tesla();

            // Act
            var result = tesla.SpeedUp() * 2;

            // Assert
            Assert.AreEqual(40, result);
        }

        [TestMethod]
        public void SlowDown_Tesla_ReturnsSpeedAfterSlowDown()
        {
            // Arrange
            ICar tesla = new Tesla();

            // Act
            tesla.SpeedUp();
            var result = tesla.SlowDown();

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void ShowCurrentSpeed_Tesla_ReturnsCurrentSpeed()
        {
            // Arrange
            ICar tesla = new Tesla();

            // Act
            tesla.SpeedUp();
            var result = tesla.ShowCurrentSpeed();

            // Assert
            Assert.AreEqual("20", result);
        }

        [TestMethod]
        public void StartEngine_Tesla_ReturnsEngineSound()
        {
            // Arrange
            ICar tesla = new Tesla();

            // Act
            tesla.SpeedUp();
            var result = tesla.StartEngine();

            // Assert
            Assert.AreEqual("-- silence ---", result);
        }

        [TestMethod]
        public void ShowCarName_Tesla_ReturnsCarName()
        {
            // Arrange
            ICar tesla = new Tesla();

            // Act
            var result = tesla.ShowCarName();

            // Assert
            Assert.AreEqual("Tesla", result);
        }

    }
}
