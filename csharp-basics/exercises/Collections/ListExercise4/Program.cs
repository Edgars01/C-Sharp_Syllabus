using System;
using System.Collections.Generic;

namespace ListExercise4
{
    class Program
    {
        private static void Main(string[] args)
        {
            // Create a list and add some colors to the list
            var colors = new List<string>
            {
                "Red",
                "Green",
                "Orange",
                "White",
                "Black"
            };

            //fixme
            string element = colors[0];
            Console.WriteLine("First element: " + element);
            //fixme
            element = colors[2];
            Console.WriteLine("Third element: " + element);
            Console.ReadKey();
        }
    }
}
