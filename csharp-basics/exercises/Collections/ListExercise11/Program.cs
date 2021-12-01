using System;
using System.Collections.Generic;

namespace ListExercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Create an List with string elements

            List<string> ParticleList = new List<string>();

            //TODO: Add 10 values to list
            ParticleList.Add("Hydrogen");
            ParticleList.Add("Helium");
            ParticleList.Add("Oxygen");
            ParticleList.Add("Carbon");
            ParticleList.Add("Neon");
            ParticleList.Add("Nitrogen");
            ParticleList.Add("Magnesium");
            ParticleList.Add("Silicon");
            ParticleList.Add("Iron");
            ParticleList.Add("Sulfur");

            //TODO: Add new value at 5th position
            ParticleList.Insert(5, "Barium");

            //TODO: Change value at last position (Calculate last position programmatically)
            ParticleList[ParticleList.Count - 1] = "Astatine";

            //TODO: Sort your list in alphabetical order
            ParticleList.Sort();

            //TODO: Check if your list contains "Foobar" element
            Console.WriteLine("Foobar? " + ParticleList.Contains("Foobar") + "\n");

            //TODO: Print each element of list using loop
            foreach (var value in ParticleList)
            {
                Console.WriteLine(value);
            }
            Console.ReadKey();
        }
    }
}
