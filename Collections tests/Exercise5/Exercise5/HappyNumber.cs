using System;
using System.Collections.Generic;

namespace Exercise5
{
    public class HappyNumber
    {
        static List<int> listOfInts = new List<int>();
        static int res = 0;
        static string message = "";
        public string IsHappy(int x)
        {
            ToDigets(x);
            Calc(listOfInts);

            while (res > 1)
            {
                ToDigets(res);
                Calc(listOfInts);

                if (res == 16)
                {
                    break;
                }
            }

            if (res == 1)
            {
                return "Happy number!";
            }
            else
            {
                return "Not happy!";
            }

        }

        public List<int> ToDigets(int num)
        {
            listOfInts.Clear();
            while (num > 0)
            {
                listOfInts.Add(num % 10);
                num = num / 10;
            }

            listOfInts.Reverse();

            return listOfInts;
        }

        public int Calc(List<int> listOfInts)
        {
            message = "";
            res = 0;
            for (int i = 0; i < listOfInts.Count; i++)
            {
                message += listOfInts[i] + "^2 + ";
                res += (int)Math.Pow(listOfInts[i], 2);
            }

            message = message.Remove(message.Length - 2);
            Console.WriteLine(message + "= " + res);
            listOfInts.Clear();

            return res;
        }
    }
}

