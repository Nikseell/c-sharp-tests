using System;
using System.IO;
using System.Linq;

namespace Exercise6
{
    public class WordCount
    {
        int lineCount = 0;
        string textWords = "";
        public int CountLines(string path)
        {
            string[] lines = File.ReadAllLines(path);

            return lines.Length;
        }

        public int CountWords(string path)
        {
            string allText = File.ReadAllText(path);
            string[] splitWords = allText.Split(' ', ',', '?', '!').ToArray();

            return splitWords.Length;
        }

        public int CountChars(string path)
        {
            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                textWords += line;
            }

            char[] charArr = textWords.ToCharArray();

            return charArr.Length;
        }
    }
}
