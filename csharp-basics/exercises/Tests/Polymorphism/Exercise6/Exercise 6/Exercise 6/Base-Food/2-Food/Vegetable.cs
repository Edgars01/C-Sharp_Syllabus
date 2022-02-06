namespace Hierarchy
{
    public class Vegetable : Food
    {
        public Vegetable(string foodType, int quantity) : base(foodType, quantity)
        {

        }

        public override string GetFoodType()
        {
            return "Vegetable";
        }
    }
}