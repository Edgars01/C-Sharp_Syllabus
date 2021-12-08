using System;

namespace exercise_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number of minutes:");
            long minutes = Convert.ToInt64(Console.ReadLine());
            long hours = minutes / 60;
            long day = hours / 24;
            long years = day / 365;
            long remainingDays = day % 365;
            Console.WriteLine($"{minutes} min = {years} years and {remainingDays} days.");
        }
    }
}
