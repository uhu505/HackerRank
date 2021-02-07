using System;

namespace AppleAndOrange
{
    internal class Program
    {
        private static void Main()
        {
            int[] apples = new int[] { -2, 2, 1 };
            int[] oranges = new int[] { 5, -6 };
            CountApplesAndOranges(7, 11, 5, 15, apples, oranges);
            Console.ReadLine();
        }

        private static void CountApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            Apple(s, t, a, apples);
            Orange(s, t, b, oranges);
        }

        private static void Apple(int s, int t, int a, int[] apples)
        {
            int sum = 0;
            for (int i = 0; i < apples.Length; i++)
            {
                if (apples[i] + a >= s && apples[i] + a <= t) sum++;
            }
            Console.WriteLine(sum);
        }

        private static void Orange(int s, int t, int b, int[] oranges)
        {
            int sum = 0;
            for (int i = 0; i < oranges.Length; i++)
            {
                if (oranges[i] + b <= t && oranges[i] + b >= s) sum++;
            }
            Console.WriteLine(sum);
        }
    }
}