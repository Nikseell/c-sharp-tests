using DragRace;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise1.Tests
{
    [TestClass]
    public class LexusTests
    {
        [TestMethod]
        public void SpeedUp_Lexus_ReturnsSpeedUpTwoTimes()
        {
            // Arrange
            ICar lexus = new Lexus();

            // Act
            var result = lexus.SpeedUp() * 2;

            // Assert
            Assert.AreEqual(34, result);
        }

        [TestMethod]
        public void SlowDown_Lexus_ReturnsSpeedAfterSlowDown()
        {
            // Arrange
            ICar lexus = new Lexus();

            // Act
            lexus.SpeedUp();
            var result = lexus.SlowDown();

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void ShowCurrentSpeed_Bentley_ReturnsCurrentSpeed()
        {
            // Arrange
            ICar lexus = new Lexus();

            // Act
            lexus.SpeedUp();
            var result = lexus.ShowCurrentSpeed();

            // Assert
            Assert.AreEqual("17", result);
        }

        [TestMethod]
        public void StartEngine_Bentley_ReturnsEngineSound()
        {
            // Arrange
            ICar lexus = new Lexus();

            // Act
            lexus.SpeedUp();
            var result = lexus.StartEngine();

            // Assert
            Assert.AreEqual("Rrrrrrr.....", result);
        }

        [TestMethod]
        public void ShowCarName_Bentley_ReturnsCarName()
        {
            // Arrange
            ICar lexus = new Lexus();

            // Act
            var result = lexus.ShowCarName();

            // Assert
            Assert.AreEqual("Lexus", result);
        }

        [TestMethod]
        public void UseNitrousOxideEngine_Bentley_ReturnsSpeedAfterUsingNitrous()
        {
            // Arrange
            INitrous lexus = new Lexus();
            
            // Act
            var result = lexus.UseNitrousOxideEngine();

            // Assert
            Assert.AreEqual(20, result);
        }

    }
}
