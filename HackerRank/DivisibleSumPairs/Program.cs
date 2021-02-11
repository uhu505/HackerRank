using System;
using System.Collections.Generic;

namespace DivisibleSumPairs
{
    internal class Program
    {
        private static void Main()
        {
            int result = DivisibleSumPairs(6, 3, new int[] { 1, 3, 2, 6, 1, 2 });
            Console.WriteLine(result);
            Console.ReadLine();
        }

        private static int DivisibleSumPairs(int n, int k, int[] ar)
        {
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if ((ar[i] + ar[j]) % k == 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}