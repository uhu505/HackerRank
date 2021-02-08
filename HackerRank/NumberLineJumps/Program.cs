using System;
using System.Linq;

namespace NumberLineJumps
{
    internal class Program
    {
        private static void Main()
        {                              // x1 - v1 / x2 - v2
            string result1 = Kangaroo(1817, 9931, 8417, 190);
            string result2 = Kangaroo(0, 2, 5, 3);
            string result3 = Kangaroo(0, 3, 4, 2);
            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.ReadLine();
        }

        private static string Kangaroo(int x1, int v1, int x2, int v2)
        {
            return FirstControl(x1, v1, x2, v2); ;
        }

        private static string FirstControl(int x1, int v1, int x2, int v2)
        {
            string result;
            if (x2 >= x1 && v2 >= v1) result = "NO";
            else
            {
                int x = x2 - x1;
                int v = v1 - v2;
                if (x % v == 0) result = "Yes";
                else result = "No";
            }
            return result;
        }
    }
}
