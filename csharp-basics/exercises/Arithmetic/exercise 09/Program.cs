using System;

namespace exercise_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your weight (kg):");
            double weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your height (cm):");
            double height = Convert.ToInt32(Console.ReadLine());
            double weightInPounds = weight * 2.2;
            double heightInInches = height * 0.39;
            double bmi = (weightInPounds * 703) / Math.Pow(heightInInches, 2);

            if (bmi >= 25)
            {
                Console.WriteLine($"You are overweight.Your BMI is: {Math.Round((decimal)bmi, 2)}");
            }
            else if (bmi <= 18.5)
            {
                Console.WriteLine($"You are underweight.Your BMI is: {Math.Round((decimal)bmi, 2)}");
            }
            else
            {
                Console.WriteLine($"Your weight is optimal.Your BMI is: {Math.Round((decimal)bmi, 2)}");
            }
            Console.ReadKey();
        }
    }
}
