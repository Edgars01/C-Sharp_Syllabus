using System;
using System.Collections.Generic;

namespace ListExercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> ParticleList = new List<string>();

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

            ParticleList.Insert(5, "Barium");
            ParticleList[ParticleList.Count - 1] = "Astatine";
            ParticleList.Sort();
            Console.WriteLine("Foobar? " + ParticleList.Contains("Foobar") + "\n");

            foreach (var value in ParticleList)
            {
                Console.WriteLine(value);
            }
            Console.ReadKey();
        }
    }
}
