using System;

namespace Exercise_8_FIGURE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of figure: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int side = 0;
            int mid = 0;
              
            for (int i = 2; i <= size; i++)
            {
                side += 4;              
            }
            for (int l = 0; l <= size; l++)
            {
                Console.Write(new String('/', side));
                Console.Write(new String('*', mid));
                Console.Write(new String('\\', side));
                Console.WriteLine();
                side -= 4;
                mid += 8;
            }
            Console.ReadKey();
        }
    }
}
