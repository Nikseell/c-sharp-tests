using System;

namespace Exercise6
{
    public class CozaLozaWoza
    {
        public string CozaLozaWozaProgram(int y)
        {
            for (int x = y; x <= 110; x += 1)
            {
                Console.Write(" ");

                if (x % 3 == 0)
                {
                    return "Coza";
                }
                else if (x % 5 == 0)
                {
                    return "Loza";
                }
                else if (x % 7 == 0)
                {
                    return "Woza";
                }
                else
                {
                    return x.ToString();
                }

                if (x % 11 == 0)
                {
                    Console.WriteLine();
                }
            }

            return null;
        }
    }
}
