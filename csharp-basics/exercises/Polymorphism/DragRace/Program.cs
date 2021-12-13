using System;
using System.Collections.Generic;
using System.Linq;

namespace DragRace
{
    class Program
    {
        /**
 * Take a look at the cars in this solution.
 * 1. Extract common behaviour to an interface called Car, and use it in the all classes.
 * Which methods will be extracted with an empty body, and which can be default?
 * 2. Create two more cars of your own choice.
 * 3. As you see there is a possibility to use some kind of boost in Lexus, extract it to a new interface
          and add that behaviour in one more car.
 * 4. Create one instance of an each car and add them to list.
 * 5. Iterate over the list 10 times, in the 3rd iteration use speed boost on the car if they have one.
 * 6. Print out the car name and speed of the fastest car
 */

        public static void Main(string[] args)
        {
            var cars = new List<ICar>();
            cars.Add(new Audi());
            cars.Add(new Bmw());
            cars.Add(new Canno());
            cars.Add(new Hyundai());
            cars.Add(new Lexus());
            cars.Add(new Tesla());

            for (var i = 1; i < 10; i++)
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