using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise12.Tests
{
    [TestClass]
    public class AccountTests
    {
        [TestMethod]
        public void Withdrawal_WithDrawalAmount_ReturnsBalanceAmountAfterWithdrawal()
        {
            // Arrange
            var mattsAccount = new Account("Matt`s Account", 1000);

            // Act
            mattsAccount.Withdrawal(100);

            // Assert
            Assert.AreEqual(900, mattsAccount.Balance());
        }

        [TestMethod]
        public void Deposit_DepositAmount_ReturnsAccountBalanceAfterDeposit()
        {
            // Arrange
            var mattsAccount = new Account("Matt`s Account", 1000);

            // Act
            mattsAccount.Deposit(120);

            // Assert
            Assert.AreEqual(1120, mattsAccount.Balance());
        }

        [TestMethod]
        public void Balance_CheckAccountBalance_ReturnsAccontBalance()
        {
            // Arrange
            var mattsAccount = new Account("Matt`s Account", 1000);

            // Act
            var result = mattsAccount.Balance();

            // Assert
            Assert.AreEqual(1000, result);
        }

        [TestMethod]
        public void ToString_ReturnsDataAboutAccount()
        {
            // Arrange
            var mattsAccount = new Account("Matt`s Account", 1000);

            // Act
            var result = mattsAccount.ToString();

            // Assert
            Assert.AreEqual("Matt`s Account: 1000", result);
        }


        [TestMethod]
        public void Name_SetNewAccountName_ReturnsNewAccountName()
        {
            // Arrange
            var mattsAccount = new Account("Matt`s Account", 1000);

            // Act
            var result = mattsAccount.Name = "Jack`s Account";

            // Assert
            Assert.AreEqual("Jack`s Account", result);
        }

        [TestMethod]
        public void Name_GetAccountName_ReturnsNewAccountName()
        {
            // Arrange
            var mattsAccount = new Account("Matt`s Account", 1000);

            // Act
            var result = mattsAccount.Name;

            // Assert
            Assert.AreEqual("Matt`s Account", result);
        }
    }
}
