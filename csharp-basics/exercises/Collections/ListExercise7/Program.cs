using System;
using System.Collections.Generic;

namespace ListExercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            var colors = new List<string>
            {
                "Red",
                "Green",
                "Orange",
                "White",
                "Black"
            };
            //      TODO: Check if list contains "White" element
            Console.Write(colors.Contains("White"));
            Console.ReadKey();
        }
    }
}
