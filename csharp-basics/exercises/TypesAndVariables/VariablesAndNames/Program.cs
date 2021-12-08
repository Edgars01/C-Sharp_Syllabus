using System;

namespace VariablesAndNames
{
    class Program
    {
        private static void Main(string[] args)
        {
            int cars, drivers, passengers, carsNotDriven, carsDriven,
                  seatsInACar, carpoolCapacity;

            double averagePassengersPerCar;

            cars = 100;
            seatsInACar = 4;
            drivers = 28;
            passengers = 90;
            carsDriven = drivers;
            averagePassengersPerCar = Convert.ToDouble(passengers) / carsDriven;
            carsNotDriven = cars - drivers;
            carpoolCapacity = carsDriven * seatsInACar;

            Console.WriteLine("There are " + cars + " cars available.");
            Console.WriteLine("There are only " + drivers + " drivers available.");
            Console.WriteLine("There will be " + carsNotDriven + " empty cars today.");
            Console.WriteLine("We can transport " + carpoolCapacity + " people today.");
            Console.WriteLine("We have " + passengers + " to carpool today.");
            Console.WriteLine("We need to put about " + averagePassengersPerCar.ToString("0.00") + " in each car.");
            Console.ReadKey();
        }
    }
}