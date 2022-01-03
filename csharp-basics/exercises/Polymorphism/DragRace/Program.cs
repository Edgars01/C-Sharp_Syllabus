using System;
using System.Collections.Generic;
using System.Linq;

namespace DragRace
{
    class Program
    {
        public static void Main(string[] args)
        {
            var cars = new List<ICar>();
            cars.Add(new Audi());
            cars.Add(new Bmw());
            cars.Add(new Canno());
            cars.Add(new Hyundai());
            cars.Add(new Lexus());
            cars.Add(new Tesla());

            for (var i = 0; i < 10; i++)
                foreach (var car in cars)
                    switch (i)
                    {
                        case 1:
                            car.StartEngine();
                            continue;
                        case 3 when car is IBoostable:
                            ((IBoostable) car).UseNitrousOxideEngine();
                            continue;
                        default:
                            car.SpeedUp();
                            break;
                    }

            foreach (var car in cars) Console.WriteLine($"\n{car.GetType().Name} : {car.ShowCurrentSpeed()}");

            var speed = 0;
            var name = "";
            foreach (var car in cars.Where(car => int.Parse(car.ShowCurrentSpeed()) > speed))
            {
                speed = int.Parse(car.ShowCurrentSpeed());
                name = car.GetName();
            }

            Console.WriteLine($"\n\nThe fastest car is {name} with speed {speed}.");
            Console.ReadKey();
        }
    }
}