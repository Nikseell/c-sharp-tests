using DragRace;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise1.Tests
{
    [TestClass]
    public class BmwTests
    {
        [TestMethod]
        public void SpeedUp_Bmw_ReturnsSpeedUpTwoTimes()
        {
            // Arrange
            ICar bmw = new Bmw();

            // Act
            var result = bmw.SpeedUp() * 2;

            // Assert
            Assert.AreEqual(30, result);
        }

        [TestMethod]
        public void SlowDown_Bmw_ReturnsSpeedAfterSlowDown()
        {
            // Arrange
            ICar bmw = new Bmw();

            // Act
            bmw.SpeedUp();
            var result = bmw.SlowDown();

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void ShowCurrentSpeed_Bmw_ReturnsCurrentSpeed()
        {
            // Arrange
            ICar bmw = new Bmw();

            // Act
            bmw.SpeedUp();
            var result = bmw.ShowCurrentSpeed();

            // Assert
            Assert.AreEqual("15", result);
        }

        [TestMethod]
        public void StartEngine_Bmw_ReturnsEngineSound()
        {
            // Arrange
            ICar bmw = new Bmw();

            // Act
            bmw.SpeedUp();
            var result = bmw.StartEngine();

            // Assert
            Assert.AreEqual("Rrrrrrr.....", result);
        }

        [TestMethod]
        public void ShowCarName_Bmw_ReturnsCarName()
        {
            // Arrange
            ICar bmw = new Bmw();

            // Act
            var result = bmw.ShowCarName();

            // Assert
            Assert.AreEqual("Bmw", result);
        }

    }
}
