using System;

namespace MoreVariablesAndPrinting
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Zed A. Shaw";
            int age = 35;
            int height = 74;  // inches
            int weight = 180; // lbs
            double heightCm = height * 2.54;
            double weightKg = weight * 0.453592;
            string eyes = "Blue";
            string teeth = "White";
            string hair = "Brown";

            Console.WriteLine("Let's talk about " + name + ".");
            Console.WriteLine("He's " + heightCm.ToString("0.00") + " cm tall.");
            Console.WriteLine("He's " + weightKg.ToString("0.00") + " kg heavy.");
            Console.WriteLine("Actually, that's not too heavy.");
            Console.WriteLine("He's got " + eyes + " eyes and " + hair + " hair.");
            Console.WriteLine("His teeth are usually " + teeth + " depending on the coffee.");
            Console.WriteLine("If I add " + age + ", " + heightCm.ToString("0.00") + ", and " + weightKg.ToString("0.00")
                               + " I get " + (age + heightCm + weightKg).ToString("0.00") + ".");
            Console.ReadKey();
        }
    }
}