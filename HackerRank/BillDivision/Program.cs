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

namespace BillDivision
{
    internal class Program
    {
        private static void Main()
        {
            BonAppetit(new List<int>() { 3, 10, 2, 9 }, 1, 12);
        }

        private static void BonAppetit(List<int> bill, int k, int b)
        {
            int mustBe;
            int TotalPrice = 0;
            int unpaid = bill[k];
            var newBill = bill.ToList();
            string result;

            newBill.Remove(unpaid);
            newBill.ForEach(delegate (int x) { TotalPrice += x; });
            mustBe = TotalPrice / 2;
            result = (mustBe == b) ? "Bon Appetit" : (b - mustBe).ToString();

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}