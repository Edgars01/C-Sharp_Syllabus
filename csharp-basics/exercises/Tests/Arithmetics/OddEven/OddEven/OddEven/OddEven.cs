using OddEven.Exceptions;
using System;

namespace OddEven
{
    public class OddEven : IOddEven
    {
        public bool CheckOdd(int number)
        {
            return number % 2 == 0;
        }

        public string IsOddOrEven(int number)
        {
            if (number < 0)
            {
                throw new InvalidValueException();
            }
            var result = CheckOdd(number);
            return result == true ? "Even" : "Odd";
        }
        
    }
}
