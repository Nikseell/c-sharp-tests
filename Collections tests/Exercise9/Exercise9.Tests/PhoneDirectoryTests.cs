using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhoneBook;

namespace Exercise9.Tests
{
    [TestClass]
    public class PhoneDirectoryTests
    {
        private PhoneDirectory _target;

        public PhoneDirectoryTests()
        {
            _target = new PhoneDirectory();
        }

        [TestMethod]
        public void PutNumber_CorrectNameAndNumber_ReturnsThatNameAlreadyExists()
        {
            // Act
            _target.PutNumber("Paul", "61323436");
            var result=_target.PutNumber("Paul", "61331245");

            // Assert
            Assert.AreEqual("Name or number already exits!", result);
        }

        [TestMethod]
        public void PutNumber_TwoSameNames_ReturnsAlreadyExistsMessage()
        {
            // Act
            _target.PutNumber("Paul", "61323436");
            var result = _target.PutNumber("Paul", "31323546");

            // Assert
            Assert.AreEqual("Name or number already exits!", result);
        }

        [TestMethod]
        public void PutNumber_TwoSameNumbers_ReturnsAlreadyExistsMessage()
        {
            // Act
            _target.PutNumber("Paul", "61323436");
            var result = _target.PutNumber("Nick", "61323436");

            // Assert
            Assert.AreEqual("Name or number already exits!", result);
        }

        [TestMethod]
        public void PutNumber_EmptyInputs_ReturnsNullMessage()
        {
            // Act
            var result = _target.PutNumber(null, null);

            // Assert
            Assert.AreEqual("Name and number cannot be null", result);
        }

        [TestMethod]
        public void GetNumber_InputName_ReturnsNumber()
        {
            // Arrange
            SortedDictionary<string, string> list = new SortedDictionary<string, string>();

            // Act
            _target.PutNumber("Paul", "61323436");
            var result = _target.GetNumber("Paul");

            // Assert
            Assert.AreEqual($"Paul number is {list.Values}", result);
        }

        [TestMethod]
        public void GetNumber_InputNameWithNoNumber_ReturnsFoundNothing()
        {
            // Act
            var result = _target.GetNumber("Paul");

            // Assert
            Assert.AreEqual($"Found nothing!", result);
        }

        [TestMethod]
        public void PrintOut_CorrectNumber_ReturnsAllNumbers()
        {
            // Act
            _target.PutNumber("Paul", "61323436");

            // Assert
            Assert.AreEqual("[Paul, 61323436]", _target.PrintOut());
        }

        [TestMethod]
        public void PrintOut_NoNumber_ReturnsNull()
        {
            // Assert
            Assert.AreEqual(null, _target.PrintOut());
        }

    }
}
