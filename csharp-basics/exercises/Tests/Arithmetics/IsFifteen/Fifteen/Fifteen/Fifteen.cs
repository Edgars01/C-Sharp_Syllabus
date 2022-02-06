using System.Collections.Generic;
using Fifteen.Exceptions;

namespace Fifteen
{
    public class Fifteen : IFifteen
    {
        public List<int> numbers;
        private int _number = 15;

        public void CheckingIfNumbersProvidedAreSmallerThanZero_OrTheirSumExceeds_15(int a, int b)
        {
            if (a < 0 || b < 0 || a + b > 15) throw new InvalidNumberException();
        }

        public bool CheckingIfProvidedNumberSumIsEqualTo_15(int a, int b)
        {
            return a + b == _number;
        }

        public bool CheckingIfProvidedNumberMinusOtherNumberIsEqualTo_15(int a, int b)
        {
            return a - b == _number || b - a == _number;
        }
    }
}
