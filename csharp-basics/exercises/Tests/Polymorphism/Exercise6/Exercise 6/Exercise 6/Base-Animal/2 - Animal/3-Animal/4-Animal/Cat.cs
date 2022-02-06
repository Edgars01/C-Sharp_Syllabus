using Exercise_6.Exception;

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
            if (food.GetType().Name.ToLower() == "vegetable") throw new InvalidParameterTypeException();
            
            return "thanks";
        }

        public override string ReturnInfo()
        {
            var result = base.ReturnInfo();
            return result;
        }
    }
}