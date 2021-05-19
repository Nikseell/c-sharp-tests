using System;

namespace Exercise6
{
    public class ReplaceLastArrayElement
    {
        static int[] array = new int[10];
        static Random random = new Random();
        static int[] array1 = new int[array.Length];

        public int[] MakeArray()
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(100);
            }
            return array;
        }

        public int[] ReplaceLastElement()
        {
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = array[i];
            }
            array1[array1.Length - 1] = -7;

            return array1;
        }
    }
}
