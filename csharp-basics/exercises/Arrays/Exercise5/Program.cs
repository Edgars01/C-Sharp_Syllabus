using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        //TODO: Write a C# program to find the index of an array element.
        private static void Main(string[] args)
        {
            int[] myArray = {25, 14, 56, 15, 36, 56, 77, 18, 29, 49};
            
            int index;
            Console.WriteLine("Enter array element for INDEX: ");
            string s = Console.ReadLine();

            if (int.TryParse(s, out int value) && value >= 1 && value <= 100)
            {
                for (int i = 0; i < myArray.Length; i++)
                {
                    if (value == myArray[i])
                    {
                        index = i;
                        Console.WriteLine($"Index position of {value} is: {index}");
                        Console.ReadKey();
                    }
                }
            }
            else
            {
                Console.WriteLine("Numbers only!");
                Console.ReadKey();
            }    
            //Expected output:
            //Index position of 36 is: 4
            //Index position of 29 is: 8
        }
    }
}
