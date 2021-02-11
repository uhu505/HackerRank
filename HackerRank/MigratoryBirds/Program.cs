using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace MigratoryBirds
{
    internal class Program
    {
        private static void Main()
        {
            int result = MigratoryBirds(new List<int>() { 1, 2, 3, 4, 5, 4, 3, 2, 1, 3, 4 });
            Console.WriteLine(result);
            Console.ReadLine();
        }

        /*
         * En çok tekrar eden sayıyı bulacağız.
         * Bulunan sayıyı return ile döndüreceğiz.
         * Eğer tekrar eden sayı sayısı ikinci bir sayı ile eşit ise küçük olan değeri alacağız.
         */

        private static int MigratoryBirds(List<int> arr)
        {
            arr.Sort();
            var groups = arr.GroupBy(p => p);    // Aynı değere sahip sayılar bir grup altına alındı.
            var groupName = 0;
            var values = 0;

            foreach (var group in groups)
            {
                var baseValue = group.Count();
                var baseGroupName = group.Key;

                if (baseValue > values && groupName < baseGroupName)
                {
                    values = baseValue;
                    groupName = baseGroupName;
                }
            }
            return groupName;
        }
    }
}