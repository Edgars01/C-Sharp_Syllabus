using System;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var fuelGauge = new FuelGauge();
            for (int i = 0; i < 10; i++)
            {
                fuelGauge.Fill();
            }
            Console.WriteLine($"fuel level:{fuelGauge.ReportLevel()}");

            var odometer = new Odometer(fuelGauge);
            Console.WriteLine("running...");
            for (int i = 0; i < 210; i++)
            {
                if (fuelGauge.CheckLevel()) 
                {
                    break;
                }
                odometer.Increment();
                Console.WriteLine($"odometer report:{odometer.Report()} fuel report: {fuelGauge.ReportLevel()}");
            }
            Console.ReadKey();
        }
    }
}
