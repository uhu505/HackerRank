using System;
using System.Collections.Generic;

namespace GradingStudents
{
    internal class Program
    {
        private static void Main() // 1
        {
            List<int> grades = new List<int>() { 73, 67, 38, 33 };
            List<int> newGrades = GradingStudents(grades);
            foreach (var item in newGrades)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        public static List<int> GradingStudents(List<int> grades) // 2
        {
            List<int> CurrentScore = new List<int>() { };
            ModBase(grades, CurrentScore);
            return CurrentScore;
        }

        private static void ModBase(List<int> grades, List<int> CurrentScore) // 2.1
        {
            for (int i = 0; i < grades.Count; i++)
            {
                int points = grades[i];
                Mod(points, CurrentScore);
            }
        }

        private static void Mod(int point, List<int> CurrentScore) // 2.2
        {
            if (point > 37) ModConditions(point, CurrentScore);
            else CurrentScore.Add(point);
        }

        private static void ModConditions(int point, List<int> CurrentScore)// 2.3
        {
            int value = point % 5;
            if (value == 0) CurrentScore.Add(point);
            else LastCheck(value, point, CurrentScore);
        }

        private static void LastCheck(int value, int point, List<int> CurrentScore)// 2.4
        {
            int interval = 5 - value;
            if (interval < 3) CurrentScore.Add(point + interval);
            else CurrentScore.Add(point);
        }
    }
}