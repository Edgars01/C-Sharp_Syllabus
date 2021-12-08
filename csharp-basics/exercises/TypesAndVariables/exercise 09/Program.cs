using System;

namespace exercise_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float distanceInMeters = 2500;
            float hours = 5;
            float minutes = 56;
            float seconds = 23;
            float timeSeconds = (hours * 3600) + (minutes * 60) + seconds;
            float mps = distanceInMeters / timeSeconds;
            float kph = (distanceInMeters / 1000) / (timeSeconds / 3600);
            float mph = kph / 1.609f;

            Console.WriteLine($"Your speed in meters/second is {mps}");
            Console.WriteLine($"Your speed in km/h is {kph}");
            Console.WriteLine($"Your speed in miles/h is {mph}");
        }
    }
}
