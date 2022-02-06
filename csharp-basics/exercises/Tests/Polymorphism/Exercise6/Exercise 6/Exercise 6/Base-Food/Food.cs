namespace Hierarchy
{
    public abstract class Food
    {
        private int _quantity;
        private string _foodType;

        public int Quantity
        {
            get => _quantity;
            set => _quantity = value;
        }

        public Food(string foodType, int quantity)
        {
            _quantity = quantity;
            _foodType = foodType;
        }

        public Food(string foodType)
        {
            _foodType = foodType;
        }

        public abstract string GetFoodType();
    }
}