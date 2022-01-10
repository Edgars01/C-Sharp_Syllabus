namespace Hierarchy
{
    public abstract class Animal
    {
        public string AnimalName { get; set; }

        public string AnimalType { get; set; }

        public double AnimalWeight { get; set; }

        public int FoodEaten { get; set; }

        public Animal(string animalName, string animalType, double animalWeight, int foodEaten)
        {
            AnimalName = animalName;
            AnimalType = animalType;
            AnimalWeight = animalWeight;
            FoodEaten = foodEaten;
        }

        public abstract string MakeSound();

        public abstract string Eat(Food food);

        public virtual string ReturnInfo()
        {
            return $"{AnimalType} { AnimalName} { AnimalWeight} { FoodEaten}";
        }
    }
}