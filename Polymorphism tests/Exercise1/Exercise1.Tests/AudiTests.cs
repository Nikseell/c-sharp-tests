using DragRace;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise1.Tests
{
    [TestClass]
    public class AudiTests
    {
        [TestMethod]
        public void SpeedUp_Audi_ReturnsSpeedUpTwoTimes()
        {
            // Arrange
            ICar audi = new Audi();

            // Act
            var result = audi.SpeedUp() * 2;

            // Assert
            Assert.AreEqual(20, result);
        }

        [TestMethod]
        public void SlowDown_Audi_ReturnsSpeedAfterSlowDown()
        {
            // Arrange
            ICar audi = new Audi();

            // Act
            audi.SpeedUp();
            var result = audi.SlowDown();

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void ShowCurrentSpeed_Audi_ReturnsCurrentSpeed()
        {
            // Arrange
            ICar audi = new Audi();

            // Act
            audi.SpeedUp();
            var result = audi.ShowCurrentSpeed();

            // Assert
            Assert.AreEqual("10", result);
        }

        [TestMethod]
        public void StartEngine_Audi_ReturnsEngineSound()
        {
            // Arrange
            ICar audi = new Audi();

            // Act
            audi.SpeedUp();
            var result = audi.StartEngine();

            // Assert
            Assert.AreEqual("Rrrrrrr.....", result);
        }

        [TestMethod]
        public void ShowCarName_Audi_ReturnsCarName()
        {
            // Arrange
            ICar audi = new Audi();

            // Act
            var result = audi.ShowCarName();

            // Assert
            Assert.AreEqual("Audi", result);
        }

    }
}
