using System;

namespace Exercise2
{
    public class CheckOddEven
    {
        public bool EvenOrOdd(int i)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine("Even Number\n");
                return true;
            }
            else
            {
                Console.WriteLine("Odd Number\n");
                return false;
            }
        }
    }
}
