using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Linq;
using System.Reflection;
using System;

namespace Exercise8.Tests
{
    [TestClass]
    public class HistogramTests
    {
        private Histogram _target;

        public HistogramTests()
        {
            _target = new Histogram();
        }

        public string PathFinder(string fileName)
        {
            return Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), fileName);
        }

        [TestMethod]
        public void GradesFromFileToList_FileName_ReturnsListOfAllGrades()
        {
            // Act
            var result = _target.GradesFromFileToList(PathFinder("midtermscores.txt"));

            // Assert
            Assert.AreEqual(51, result.Count);
        }

        [TestMethod]
        public void GetGradeCount_GradeFromTo_Returns()
        {
            // Act
            var result = _target.GetGradeCount(60, 69);

            // Assert
            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void GetGradeCount_GradeFromToNegative_Returns0()
        {
            // Act
            var result = _target.GetGradeCount(-2, -4);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void GetGradeCount_GradeFromTo_Returns1()
        {
            // Act
            var result = _target.GetGradeCount(100, 100);

            // Assert
            Assert.AreEqual(1, result);
        }
    }
}
