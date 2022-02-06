using System;
using System.Collections.Generic;
using System.Linq;

namespace DragRace
{
    public class FastestCar : IFastestCar
    {
        
        public string NameOFFastestCar(List<ICar> cars)
        {
            var speed = 0;
            var name = "";

            foreach (var car in cars.Where(car => int.Parse(car.ShowCurrentSpeed()) > speed))
            {
                speed = int.Parse(car.ShowCurrentSpeed());
                name = car.GetName();
            }

            return name;
        }
    }
}
