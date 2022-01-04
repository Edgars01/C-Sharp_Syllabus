using System;
using System.Collections.Generic;

namespace exercise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myHash = new HashSet<string>();
            var input = "";
            do
            {
                Console.Write(" Enter name: ");
                input = Console.ReadLine();
                myHash.Add(input);
            } while (input != "");

            string output = " Unique names in HashSet: ";

            foreach (var name in myHash)
            {
                output += " " + name;
            }

            Console.WriteLine(output);
            Console.ReadKey();
        }
    }
}
