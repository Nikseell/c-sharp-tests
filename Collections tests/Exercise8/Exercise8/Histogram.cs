using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Exercise8
{
    public class Histogram
    {
        private static string allGrades = "";
        private static List<int> grades = new List<int>();
        private static int count = 0;

        public List<int> GradesFromFileToList(string path)
        {
            var readText = File.ReadAllText(path);
            allGrades = readText;
            return grades = allGrades.Split(' ').Select(Int32.Parse).ToList();
        }

        public int GetGradeCount(int from, int to)
        {
            count = 0;
            for (int x = 0; x < grades.Count; x++)
            {
                if (grades[x] >= from && grades[x] <= to)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
