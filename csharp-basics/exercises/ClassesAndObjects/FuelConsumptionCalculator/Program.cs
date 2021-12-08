using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelConsumptionCalculator
{
    class Program
    {
        private static void Main(string[] args)
        {
            int startKilometers;
            int liters;
            Car BatMobile = new Car(0);
            
            for (int i = 0; i < 2; i++)
            {
                Console.Write("Enter first reading: ");
                startKilometers = Convert.ToInt32(Console.ReadLine());    
                Console.Write("Enter liters reading: ");
                liters = Convert.ToInt32(Console.ReadLine());
                BatMobile.FillUp(startKilometers, liters);
                BatMobile.FillUp(startKilometers, liters);
                Console.WriteLine();
            }

            Console.WriteLine("Kilometers per liter are " + BatMobile.CalculateConsumption());

            if (BatMobile.GasHog() == false)
            {
                Console.WriteLine($"Economic Car {BatMobile.EconomyCar()}");
            }
            else
            {
                Console.WriteLine($" gasHog: {BatMobile.GasHog()}");
            }
            
            Console.ReadKey();
        }
    }
}
