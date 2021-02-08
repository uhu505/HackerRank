using System;
using System.Collections.Generic;

namespace SubarrayDivision
{
    internal class Program
    {
        private static void Main()
        {
            int result = Birthday(new List<int> { 2, 5, 1, 3, 4, 4, 3, 5, 1, 1, 2, 1, 4, 1, 3, 3, 4,
                2, 1 }, 18, 7);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        private static int Birthday(List<int> s, int d, int m)
        {
            int[] numbers;
            int listLength = s.Count;
            int a = 0;
            if (listLength == 1) a = 1;
            numbers = new int[listLength - 1 + a];

            ListWander(s, m, numbers, listLength);

            return LastControl(numbers, d);
        }

        private static void ListWander(List<int> s, int m, int[] numbers, int listLength)
        {
            for (int i = 0; i < listLength; i++)
            {
                if (listLength > 1)
                {
                    if (i == listLength - 1) break;
                    else
                    {
                        int ab = 0;
                        for (int j = i; j < m + i; j++)
                        {
                            if (i > listLength - m) break;
                            else ab += s[j];
                        }
                        numbers[i] = ab;
                    };
                }
                else numbers[i] = s[i];
            }
        }

        private static int LastControl(int[] array, int d)
        {
            int count = 0;
            foreach (var item in array)
            {
                if (item == d) count++;
            }
            return count;
        }
    }
}