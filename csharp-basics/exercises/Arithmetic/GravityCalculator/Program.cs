using System;

namespace GravityCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double gravity = -9.81;  // Earth's gravity in m/s^2
            double initialVelocity = 0.0;
            double fallingTime = 51.0;
            double initialPosition = 0.0;
            double finalPosition = 0.5 * (gravity * (fallingTime * fallingTime)) + initialVelocity * (fallingTime);
            Console.WriteLine("The object's position after " + fallingTime + " seconds falling from "
                + initialPosition + "m (sea level) is " + finalPosition + " m.");
            Console.ReadKey();
        }
    }
}
