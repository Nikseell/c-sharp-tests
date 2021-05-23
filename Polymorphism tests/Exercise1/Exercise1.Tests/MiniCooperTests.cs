using DragRace;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise1.Tests
{
    [TestClass]
    public class MiniCooperTests
    {
        [TestMethod]
        public void SpeedUp_MiniCooper_ReturnsSpeedUpTwoTimes()
        {
            // Arrange
            ICar miniCooper = new MiniCooper();

            // Act
            var result = miniCooper.SpeedUp() * 2;

            // Assert
            Assert.AreEqual(60, result);
        }

        [TestMethod]
        public void SlowDown_MiniCooper_ReturnsSpeedAfterSlowDown()
        {
            // Arrange
            ICar miniCooper = new MiniCooper();

            // Act
            miniCooper.SpeedUp();
            var result = miniCooper.SlowDown();

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void ShowCurrentSpeed_MiniCooper_ReturnsCurrentSpeed()
        {
            // Arrange
            ICar miniCooper = new MiniCooper();

            // Act
            miniCooper.SpeedUp();
            var result = miniCooper.ShowCurrentSpeed();

            // Assert
            Assert.AreEqual("30", result);
        }

        [TestMethod]
        public void StartEngine_MiniCooper_ReturnsEngineSound()
        {
            // Arrange
            ICar miniCooper = new MiniCooper();

            // Act
            miniCooper.SpeedUp();
            var result = miniCooper.StartEngine();

            // Assert
            Assert.AreEqual("Rrr...", result);
        }

        [TestMethod]
        public void ShowCarName_MiniCooper_ReturnsCarName()
        {
            // Arrange
            ICar miniCooper = new MiniCooper();

            // Act
            var result = miniCooper.ShowCarName();

            // Assert
            Assert.AreEqual("Mini Cooper", result);
        }

        [TestMethod]
        public void UseNitrousOxideEngine_MiniCooper_ReturnsSpeedAfterUsingNitrous()
        {
            // Arrange
            INitrous miniCooper = new MiniCooper();

            // Act
            var result = miniCooper.UseNitrousOxideEngine();

            // Assert
            Assert.AreEqual(15, result);
        }

    }
}
