using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise5.Tests
{
    [TestClass]
    public class DateTests
    {
        [TestMethod]
        public void DisplayDate_CorrectDate_ReturnsDate()
        {
            // Arrange
            Date date = new Date(24, 9, 1999);

            // Assert
            Assert.AreEqual("9/24/1999", date.DisplayDate());
        }

        [TestMethod]
        public void DisplayDate_InvalidDate_ReturnsInvalidDateMessage()
        {
            // Arrange
            Date date = new Date(0, 9, 1999);

            // Assert
            Assert.AreEqual("Invalid date!", date.DisplayDate());
        }
    }
}
