using System;

namespace AddNumbers_01
{
    class Program
    {
        //Fix the syntax errors
        static void Main(string[] args)
        {
            Console.WriteLine(AddNumbers(1, 1, 3)); //Expected 5
            Console.ReadKey();
        }

        private static int AddNumbers(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}
