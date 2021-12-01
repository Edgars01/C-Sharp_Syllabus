using System;

namespace Output_01
{
    class Program
    {
        //finish Main method so it shows the result from function.

        static void Main(string[] args)
        {
            Console.WriteLine(GetNumber());
            Console.ReadKey();
        }

        static int GetNumber()
        {
            return new Random().Next() * 10;
        }
    }
}
