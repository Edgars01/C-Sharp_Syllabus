using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;

namespace Histogram
{
    internal class Program
    {
        public const string Path = "../../midtermscores.txt";
        public static string readText = File.ReadAllText(Path);
        public static string[] textWNewLines = readText.Split(' ');
        public static List<int> listOfIntegers = textWNewLines.Select(int.Parse).ToList();

        public static void Main(string[] args)
        {
            listOfIntegers.Sort();

            var dictionary = new Dictionary<string, string>
            {
                {"00-09:", ""},
                {"10-19:", ""},
                {"20-29:", ""},
                {"30-39:", ""},
                {"40-49:", ""},
                {"50-59:", ""},
                {"60-69:", ""},
                {"70-79:", ""},
                {"80-89:", ""},
                {"90-99:", ""},
                {"  100:", ""}
            };

            foreach (var integer in listOfIntegers)
            {
                var i = 0;
                for (var j = 9; j < 99; j += 10, i += 10)
                    if (integer >= i && integer <= j)
                        dictionary[$"{i}-{j}:"] = GetNumberOfScores(i, j);

                if (integer == 100) dictionary["  100:"] = GetNumberOfScores(100, 100);
            }

            foreach (var scoreLine in dictionary) Console.WriteLine(scoreLine.Key + scoreLine.Value);

            Console.ReadKey();
        }

        public static string GetNumberOfScores(int low, int high)
        {
            var str = string.Empty;

            foreach (var variable in listOfIntegers)
                if (variable >= low && variable <= high)
                    str += "*";

            return str;
        }
    }
}
