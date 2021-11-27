using System;

namespace Exercise4
{
    class Program
    {       
        private static void Main(string[] args)
        {
            int[] myArray =
            {
                1789, 2035, 1899, 1456, 2013,
                1458, 2458, 1254, 1472, 2365,
                1456, 2265, 1457, 2456
            };

            int toFind = 1245;
            
            foreach (int n in myArray) 
            {
                if (n == toFind) 
                {    
                    Console.WriteLine("Contains!");
                    break; 
                }
            }
            Console.WriteLine($"Doesn't contain {toFind}.");
            Console.ReadKey();
        }
    }
}
