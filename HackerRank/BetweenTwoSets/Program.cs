using System;
using System.Linq;

namespace BetweenTwoSets
{
    internal class Program
    {
        private static void Main()
        {
            int[] array = BreakingRecords(new int[] { 3, 4, 21, 36, 10, 28, 35, 5, 24, 42 });
            Console.Write("{0} {1}", array[0], array[1]);
            Console.ReadLine();
        }

        /*
           * KURALLAR: *
           * Max rekoru hesaplamak için, öncelikle ilk hesaplanmış rekordan yüksek olması gerekir.
           * Min rekoru hesaplamak için, öncelikle ilk hesaplanmış rekordan düşük olması gerekir.
           * Yukardaki iki şarta uymayan skorlar, yeni bir rekor olarak girilmeyecek.
        */

        private static int[] BreakingRecords(int[] scores)
        {
            int minRecord;
            int minBase = int.MaxValue;
            int maxRecord;
            int maxBase = int.MinValue;
            int[] holder = new int[2] { -1, -1 }; // -1 verilme sebebi ilk alınan değerler bir skor sayılmadığı için.
            foreach (var item in scores)
            {
                minRecord = item;
                maxRecord = item;
                if (minBase > minRecord)
                {
                    minBase = minRecord;
                    holder[1]++;
                }
                if (maxBase < maxRecord)
                {
                    maxBase = maxRecord;
                    holder[0]++;
                }
            }
            return holder;
        }
    }
}