using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    public class Cat : Feline
    {
        public string Breed { get; set; }

        public Cat(string animalName, string animalType, double animalWeight, int foodEaten, string livingRegion, string breed)
            : base(animalName, animalType, animalWeight, foodEaten, livingRegion)
        {
            Breed = breed;
        }

        public override string MakeSound()
        {
            return "meeeeeeeeeeui";
        }

        public override string Eat(Food food)
        {
            if (food.GetFoodType() != "Meat")
            {
                Console.WriteLine($"{AnimalType} are not eating that type of food!");
            }

            return $"{AnimalType} {AnimalName} {AnimalWeight} {LivingRegion} {FoodEaten} {Breed}";
        }

        public override string ReturnInfo()
        {
            var result = base.ReturnInfo();
            return result;
        }
    }
}
