using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DrawingBook
{
    internal class Program
    {
        private static void Main()
        {
            int result = PageCount(6, 5);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        private static int PageCount(int n, int p)
        {
            int Front = n / 2;
            int FrontTurnCount = p / 2;
            int BackTurnCount = Front - FrontTurnCount;
            return Math.Min(FrontTurnCount, BackTurnCount);
        }
    }
}
