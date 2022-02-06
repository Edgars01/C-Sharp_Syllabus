using Exercise1.Exception;

namespace Exercise1
{
    public class Product
    {
        public string _name;
        public double _priceAtStart;
        public double _amountAtStart;

        public void ValueException()
        {
            throw new OneOfValuesNotProvidedException();
        }

        public Product(string name, double priceAtStart, double amountAtStart)
        {
            _name = name;
            _priceAtStart = priceAtStart;
            _amountAtStart = amountAtStart;
        }

        public string PrintName()
        {
            if (_name == null) ValueException();

            return _name;
        }

        public double PrintQuantity()
        {
            if (_amountAtStart == 0) ValueException();

            return _amountAtStart;
        }

        public double PrintPrice()
        {
            if (_priceAtStart == 0) ValueException();

            return _priceAtStart;
        }

        public string ChangeName(string newName)
        {
            if (newName == null) ValueException();

            _name = newName;
            return newName;
        }

        public double ChangeQuantity(int newAmount)
        {
            if (newAmount == 0) ValueException();

            _amountAtStart = newAmount;
            return newAmount;
        }

        public double ChangePrice(double newPrice)
        {
            if (newPrice == 0) ValueException();

            _priceAtStart = newPrice;
            return newPrice;
        }
    }
}
