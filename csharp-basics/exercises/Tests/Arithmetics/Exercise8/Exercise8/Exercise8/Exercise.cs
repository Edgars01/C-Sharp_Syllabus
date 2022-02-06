using System;
using Exercise8.Exception;

namespace Exercise8
{
    public class Exercise : IExercise
    {
        public double MinimumWage()
        {
            return 8.00;
        }

        public int CalculatePay(double pay, double hours)
        {
            var minimumWage = MinimumWage();
            double maxHours = 60;
            double totalSalary;
            if (pay < minimumWage) throw new InvalidWageException();
            if (hours > maxHours) throw new InvalidHoursException();
            if (hours > 40) totalSalary = pay * 40 + 1.5 * pay * (hours - 40);
            else totalSalary = pay * hours;

            return (int) Math.Floor(totalSalary);
        }
    }
}
