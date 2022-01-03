namespace Exercise1
{
    public class Product
    {
        public string _name;
        public double _priceAtStart;
        public int _amountAtStart;
       
        public Product(string name, double priceAtStart, int amountAtStart)
        {
            _name = name;
            _priceAtStart = priceAtStart;
            _amountAtStart = amountAtStart;
        }

        public string PrintProduct()
        {
            return $"{_name}, price {_priceAtStart}, amount {_amountAtStart}";
        }

        public int ChangeQuantity(int newAmount)
        {
            _amountAtStart = newAmount;
            return newAmount;
        }

        public double ChangePrice(double newPrice)
        {
            _priceAtStart = newPrice;
            return newPrice;
        }
    }
}
