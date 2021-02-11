using System;
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

namespace SalesByMatch
{
    internal class Program
    {
        private static void Main()
        {
            int result = SockMerchant(9, new int[] { 10, 20, 20, 10, 10, 30, 50, 10, 20 });
            Console.WriteLine(result);
            Console.ReadLine();
        }

        private static int SockMerchant(int n, int[] ar)
        {
            List<int> newAr = new List<int>(ar);
            var groups = newAr.GroupBy(p => p);
            int result = 0;

            foreach (var group in groups)
            {
                var baseValue = group.Count() / 2;
                int calculate = (baseValue % 2 != 0) ? result += baseValue-- : result += baseValue;
            }
            return result;
        }
    }
}