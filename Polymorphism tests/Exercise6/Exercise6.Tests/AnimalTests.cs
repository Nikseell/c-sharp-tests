using Hierarchy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise6.Tests
{
    [TestClass]
    public class AnimalTests
    {
        [TestMethod]
        public void MakeSound_CorrectMouseInput_ReturnsMouseSound()
        {
            // Arrange
            Animal mouse = new Mouse("Jerry", "Mouse", 0.2,  "Wall");

            // Assert
            Assert.AreEqual("Pii - pii", mouse.MakeSound());
        }

        [TestMethod]
        public void Eat_MouseWrongTypeOfFood_Returns0()
        {
            // Arrange
            Animal mouse = new Mouse("Jerry", "Mouse", 0.2,  "Wall");

            // Act
            var result = mouse.Eat(new Meat(2));

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Eat_MouseCorrectTypeOfFood_ReturnsFoodAmount()
        {
            // Arrange
            Animal mouse = new Mouse("Jerry", "Mouse", 0.2, "Wall");

            // Act
            var result = mouse.Eat(new Vegetable(2));

            // Assert
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void MakeSound_CorrectZebraInput_ReturnsZebraSound()
        {
            // Arrange
            Animal zebra = new Zebra("Ricky", "Zebra", 290, "Lithuania");

            // Assert
            Assert.AreEqual("Zee - zee", zebra.MakeSound());
        }

        [TestMethod]
        public void Eat_ZebraWrongTypeOfFood_Returns0()
        {
            // Arrange
            Animal zebra = new Zebra("Ricky", "Zebra", 290, "Lithuania");

            // Act
            var result = zebra.Eat(new Meat(2));

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Eat_ZebraCorrectTypeOfFood_ReturnsFoodAmount()
        {
            // Arrange
            Animal zebra = new Zebra("Ricky", "Zebra", 290, "Lithuania");

            // Act
            var result = zebra.Eat(new Vegetable(2));

            // Assert
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void MakeSound_CorrctCatInput_ReturnsMouseSound()
        {
            // Arrange
            Animal cat = new Cat("Pingles", "Cat", 3, "Zoo", "Russian Blue");

            // Assert
            Assert.AreEqual("Meow - meow", cat.MakeSound());
        }

        [TestMethod]
        public void Eat_CatCorrectTypeOfFood_ReturnsFoodAmount()
        {
            // Arrange
            Animal cat = new Cat("Pingles", "Cat", 3, "Zoo", "Russian Blue");

            // Act
            var result = cat.Eat(new Vegetable(2));

            // Assert
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void ToSting_CorrectCatInput_ReturnsInformationAboutCat()
        {
            // Arrange
            Animal cat = new Cat("Pingles", "Cat", 3, "Zoo", "Russian Blue");

            // Act
            var result = cat.ToString();

            // Assert
            Assert.AreEqual("Cat, [Pingles, Russian Blue, 3, Zoo, 0]", result);
        }

        [TestMethod]
        public void MakeSound_CorrectTigerInput_ReturnsMouseSound()
        {
            // Arrange
            Animal tiger = new Tiger("Leon", "Tiger", 600, "India");

            // Assert
            Assert.AreEqual("Roaar!", tiger.MakeSound());
        }

        [TestMethod]
        public void Eat_TigerWroangTypeOfFood_Returns0()
        {
            // Arrange
            Animal tiger = new Tiger("Leon", "Tiger", 600, "India");

            // Act
            var result = tiger.Eat(new Vegetable(2));

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Eat_TigerCorrecatTypeOfFood_ReturnsFoodAmount()
        {
            // Arrange
            Animal tiger = new Tiger("Leon", "Tiger", 600, "India");

            // Act
            var result = tiger.Eat(new Meat(2));

            // Assert
            Assert.AreEqual(2, result);
        }
    }
}
