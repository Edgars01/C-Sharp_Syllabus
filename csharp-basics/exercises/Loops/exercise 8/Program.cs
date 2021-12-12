using System;

namespace Exercise_8_FIGURE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of figure: ");
            var size = Convert.ToInt32(Console.ReadLine());
            var side = 0;
            var mid = 0;

            for (var i = 2; i <= size; i++) side += 4;

            for (var l = 0; l <= size; l++)
            {
                Console.Write(new string('/', side));
                Console.Write(new string('*', mid));
                Console.Write(new string('\\', side));
                Console.WriteLine();
                side -= 4;
                mid += 8;
            }
            Console.ReadKey();
        }
    }
}