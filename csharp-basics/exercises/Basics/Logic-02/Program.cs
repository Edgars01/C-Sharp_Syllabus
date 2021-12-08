using System;

namespace Logic_02
{
    class Program
    {
        //todo: fix the code.
        static void Main(string[] args)
        {
            Console.WriteLine(Trim(" Codelex ")); //Expected "Codelex"
            Console.ReadKey();
        }

        static string Trim(string text)
        {
            return text.Trim();
        }
    }
}
