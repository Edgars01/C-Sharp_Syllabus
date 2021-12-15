using System;

namespace Hierarchy
{
    public class Tiger : Feline
    {
        public Tiger(string animalName, string animalType, double animalWeight, int foodEaten, string livingRegion)
            : base(animalName, animalType, animalWeight, foodEaten, livingRegion)
        {

        }

        public override string MakeSound()
        {
            return "rreeeeeeeeeeeee";
        }

        public override string Eat(Food food)
        {
            if (food.GetFoodType() != "Meat")
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
    }
}
