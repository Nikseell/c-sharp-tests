using DragRace;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise1.Tests
{
    [TestClass]
    public class BentleyTests
    {
        [TestMethod]
        public void SpeedUp_Bentley_ReturnsSpeedUpTwoTimes()
        {
            // Arrange
            ICar bentley = new Bentley();

            // Act
            var result = bentley.SpeedUp() * 2;

            // Assert
            Assert.AreEqual(26, result);
        }

        [TestMethod]
        public void SlowDown_Bentley_ReturnsSpeedAfterSlowDown()
        {
            // Arrange
            ICar bentley = new Bentley();

            // Act
            bentley.SpeedUp();
            var result = bentley.SlowDown();

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void ShowCurrentSpeed_Bentley_ReturnsCurrentSpeed()
        {
            // Arrange
            ICar bentley = new Bentley();

            // Act
            bentley.SpeedUp();
            var result = bentley.ShowCurrentSpeed();

            // Assert
            Assert.AreEqual("13", result);
        }

        [TestMethod]
        public void StartEngine_Bentley_ReturnsEngineSound()
        {
            // Arrange
            ICar bentley = new Bentley();

            // Act
            bentley.SpeedUp();
            var result = bentley.StartEngine();

            // Assert
            Assert.AreEqual("Brumm...", result);
        }

        [TestMethod]
        public void ShowCarName_Bentley_ReturnsCarName()
        {
            // Arrange
            ICar bentley = new Bentley();

            // Act
            var result = bentley.ShowCarName();

            // Assert
            Assert.AreEqual("Bentley", result);
        }

    }
}
