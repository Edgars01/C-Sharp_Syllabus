using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    public abstract class Mammal : Animal
    {
        public string LivingRegion { get; set; }

        protected Mammal(string animalName, string animalType, double animalWeight, int foodEaten, string livingRegion)
            : base(animalName, animalType, animalWeight, foodEaten)
        {
            LivingRegion = livingRegion;
        }

        public override string ReturnInfo()
        {
            var result = base.ReturnInfo();
            result += $", {LivingRegion}";
            return result;
        }
    }
}