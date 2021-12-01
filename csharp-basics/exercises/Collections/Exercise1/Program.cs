using System;
using System.Collections.Generic;

namespace Exercise1
{
    class Program
    {
        /**
           * Origination:
           * Audi -> Germany
           * BMW -> Germany
           * Honda -> Japan
           * Mercedes -> Germany
           * VolksWagen -> Germany
           * Tesla -> USA
           */

        private static void Main(string[] args)
        {
            string[] array = { "Audi", "BMW", "Honda", "Mercedes", "VolksWagen", "Mercedes", "Tesla" };

            //todo - replace array with an List and print out the results

            var list = new List<string> { "Audi", "BMW", "Honda", "Mercedes", "VolksWagen", "Mercedes", "Tesla" };
            Console.WriteLine(" List: " + string.Join(", ", list) + "\n");

            //todo - replace array with a HashSet and print out the results

            var hashset = new HashSet<string> { "Audi", "BMW", "Honda", "Mercedes", "VolksWagen", "Mercedes", "Tesla" };
            Console.WriteLine(" Hashset: " + string.Join(", ", hashset) + "\n");

            //todo - replace array with a Dictionary (use brand as key and origination as value) and print out the results

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
