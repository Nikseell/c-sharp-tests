using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise8.Tests
{
    [TestClass]
    public class HowMuchPayTests
    {
        private HowMuchPay _target;

        public HowMuchPayTests()
        {
            _target = new HowMuchPay();
        }

        [TestMethod]
        public void SalaryCalc_BasePayUnderMinimumWage_Returns0()
        {
            // Act
            var result = _target.SalaryCalc(7.50, 35);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void SalaryCalc_HoursWorkedOverMaximum_Returns0()
        {
            // Act
            var result = _target.SalaryCalc(7.50, 61);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void SalaryCalc_BasePayNegative_Returns0()
        {
            // Act
            var result = _target.SalaryCalc(-2, 40);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void SalaryCalc_HoursWorkedNegative_Returns0()
        {
            // Act
            var result = _target.SalaryCalc(8.5, -30);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void SalaryCalc_BasePayOverMinimumAndHoursWorkedOver40_ReturnsTotalSalary()
        {
            // Act
            var result = _target.SalaryCalc(8.20, 47);

            // Assert
            Assert.AreEqual(414.1, result);
        }

        [TestMethod]
        public void SalaryCalc_BasePayOverMinimumAndHoursWorkedUnder40_ReturnsTotalSalary()
        {
            // Act
            var result = _target.SalaryCalc(9.6, 30);

            // Assert
            Assert.AreEqual(288, result);
        }
    }
}
