using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise12.Tests
{
    [TestClass]
    public class ProgramTests
    {
        private Program _target;

        public ProgramTests()
        {
            _target = new Program();
        }
        [TestMethod]
        public void Transfer_AccountFromAccountTo_ReturnsMoneyAmountInAccount()
        {
            // Arrange
            var aAccount = new Account("A account", 100.00);
            var bAccount = new Account("B account", 0);

            // Act
            _target.Transfer(aAccount, bAccount, 50.0);

            // Assert
            Assert.AreEqual(50, bAccount.Balance());
        }
    }
}
