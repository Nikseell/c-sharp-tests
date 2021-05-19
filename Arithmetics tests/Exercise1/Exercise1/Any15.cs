using System;

namespace Exercise1
{
    public class Any15
    {
        public bool Has15(int x, int y)
        {
            if (x == 15 || y == 15 || x + y == 15 || x - y == 15 || x - y == 15)
            {
                Console.WriteLine("True");
                return true;
            }
            else
            {
                Console.WriteLine("False");
                return false;
            }
        }
    }
}
