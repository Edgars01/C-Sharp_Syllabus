using System;
using System.Collections.Generic;


namespace ListExercise1
{
    class Program
    {
        private static void Main(string[] args)
        {
            var colors = new List<string>();

            colors.Add("Red");
            colors.Add("Dark Red");
            colors.Add("Scarlet Red");
            colors.Add("Burgundy Red");
            colors.Add("Vermilion Red");

            Console.WriteLine();

            Console.WriteLine(" Fun physics fact! If an object absorbs all colors but one, we see the color it does not absorb.\n");
            Console.WriteLine(" List of Red: " + string.Join(", ", colors));
            Console.ReadLine();
        }
    }
}
