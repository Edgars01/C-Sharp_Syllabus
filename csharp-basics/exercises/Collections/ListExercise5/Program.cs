using System;
using System.Collections.Generic;

namespace ListExercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            var colors = new List<string>
            {
                "Red",
                "Green",
                "Violet",
                "White",
                "Black"
            };

            Console.WriteLine(string.Join(",", colors));

            //TODO: Change the third element with "Yellow"
            colors[2] = "Yellow";
            Console.WriteLine(string.Join(",", colors));
            Console.ReadKey();
        }
    }
}
