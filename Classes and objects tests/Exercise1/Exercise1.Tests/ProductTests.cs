using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise1.Tests
{
    [TestClass]
    public class ProductTests
    {
        [TestMethod]
        public void ChangeQuantity_QuantityAmount_ReturnsChangedQuantityForProduct()
        {
            // Arrange
            Product item1 = new Product("Logitech mouse", 70.00, 14);

            // Act
            var result = item1.ChangeQuantity(25);

            // Assert
            Assert.AreEqual(25, result);
        }

        [TestMethod]
        public void ChangePrice_PriceChange_ReturnsChangedPriceForProduct()
        {
            // Arrange
            Product item1 = new Product("Logitech mouse", 70.00, 14);

            // Act
            var result = item1.ChangePrice(85.00);

            // Assert
            Assert.AreEqual(85.00, result);
        }

        [TestMethod]
        public void PrintProduct_ReturnsProductDetails()
        {
            // Arrange
            Product item1 = new Product("Logitech mouse", 70.00, 14);

            // Act
            item1.PrintProduct();

            // Assert
            Assert.AreEqual("Logitech mouse, price 70, amount 14", item1.PrintProduct());
        }
    }
}
