using System;

namespace exercise_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculatePay(7.50, 35);

            CalculatePay(8.20, 47);
            
            CalculatePay(10.00, 73);

            CalculatePay(78000.50, 32125);
        }
        public static int CalculatePay(double pay, double hours)
        {
            double minimumWage = 8.00;
            double maxHours = 60;
            double totalSalary = 0;
            if ((pay < minimumWage) || (hours > maxHours))
            {
                Console.WriteLine("Error!");
            }
            else
            {
                if (hours > 40)
                {
                    totalSalary = pay * 40 + 1.5 * pay * (hours - 40);
                }
                else
                {
                    totalSalary = pay * hours;
                }
                Console.WriteLine("Your total salary is " + totalSalary);
            }
            return (int)totalSalary;
        }
    }
}
