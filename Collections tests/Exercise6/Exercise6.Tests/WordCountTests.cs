using System.IO;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise6.Tests
{
    [TestClass]
    public class WordCountTests
    {
        private WordCount _target;

        public WordCountTests()
        {
            _target = new WordCount();
        }

        public string PathFinder(string fileName)
        {
            return Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), fileName);
        }

        [TestMethod]
        public void CountLines_FileName_ReturnsLineCount()
        {
            // Act
            var result = _target.CountLines(PathFinder("lear.txt"));

            //Assert
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void CountWords_FileName_ReturnsWordsCount()
        {
            // Act
            var result = _target.CountWords(PathFinder("lear.txt"));

            //Assert
            Assert.AreEqual(47, result);
        }

        [TestMethod]
        public void CountChars_FileName_ReturnsCharCount()
        {
            // Act
            var result = _target.CountChars(PathFinder("lear.txt"));

            //Assert
            Assert.AreEqual(248, result);
        }
    }
}
