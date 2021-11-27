using System;

namespace exercise_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test(17, 2));
            Console.ReadLine();
        }

        public static bool test(int a, int b)
        {
            return a == 15 || b == 15 || a + b == 15 || Math.Abs(a - b) == 15;
        }
    }
}
