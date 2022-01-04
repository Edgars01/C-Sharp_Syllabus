using System;
using System.Collections.Generic;

namespace Exercise1
{
    class Program
    {
        private static void Main(string[] args)
        {
            string[] array = { "Audi", "BMW", "Honda", "Mercedes", "VolksWagen", "Mercedes", "Tesla" };

            var list = new List<string> { "Audi", "BMW", "Honda", "Mercedes", "VolksWagen", "Mercedes", "Tesla" };
            Console.WriteLine(" List: " + string.Join(", ", list) + "\n");

            var hashset = new HashSet<string> { "Audi", "BMW", "Honda", "Mercedes", "VolksWagen", "Mercedes", "Tesla" };
            Console.WriteLine(" Hashset: " + string.Join(", ", hashset) + "\n");

            Console.WriteLine(" Dictionary: \n");
            var dictionary = new Dictionary<string, string>();
            dictionary.Add(" Audi", "Audi AG");
            dictionary.Add(" BMW", "Bayerische Motoren Werke AG");
            dictionary.Add(" Honda", "Honda Motor Company");
            dictionary.Add(" Mercedes", "company..");
            dictionary.Add(" VolksWagen", "company");
            dictionary.Add(" Tesla", "another company");

            foreach (var element in dictionary)
            {
                Console.WriteLine($"{element.Key}, {element.Value}");
            }

            Console.ReadKey();
        }
    }
}
