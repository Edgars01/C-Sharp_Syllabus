using System;

namespace Hierarchy
{
    public class Mouse : Mammal
    {
        public Mouse(string animalName, string animalType, double animalWeight, int foodEaten, string livingRegion):
            base(animalName, animalType, animalWeight, foodEaten, livingRegion)
        {
            LivingRegion = livingRegion;
        }

        public override string Eat(Food food)
        {
            if (food.GetFoodType() != "Vegetable")
            {
                Console.WriteLine($"{AnimalType} are not eating that type of food!");
            }

            return $"{AnimalType} {AnimalName} {AnimalWeight} {LivingRegion} {FoodEaten}";
        }

        public override string ReturnInfo()
        {
            var result = base.ReturnInfo();
            return result;
        }

        public override string MakeSound()
        {
            return "eeeeeeeeeeeeeee";
        }
    }
}
