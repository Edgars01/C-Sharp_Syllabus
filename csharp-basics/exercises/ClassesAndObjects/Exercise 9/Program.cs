using System;

namespace Exercise_9
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var point1 = new PointsToSwap(5, 3);
            var point2 = new PointsToSwap(4, 2);
            Console.WriteLine("before swap: ");
            Console.WriteLine("(" + point1._x + ", " + point1._y + ")");
            Console.WriteLine("(" + point2._x + ", " + point2._y + ")");
            PointsToSwap.Swap(ref point1, ref point2);
            Console.WriteLine("after swap: ");
            Console.WriteLine("(" + point1._x + ", " + point1._y + ")");
            Console.WriteLine("(" + point2._x + ", " + point2._y + ")");
            Console.ReadKey();
        }
    }
}
