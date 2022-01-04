using System;

namespace CozaLozaWoza
{
    public class CozaLozaWoza : ICozaLozaWoza
    {
        public int Brain(int number)
        {
            while (number <= 110)
                Conditions(number);

            return number;
        }

        public string Conditions(int number)
        {
            if (number % 3 == 0 && number % 5 == 0) return "CozaLoza ";
            if (number % 5 == 0 && number % 7 == 0) return "LozaCoza ";
            if (number % 3 == 0)
                return "Coza ";
            if (number % 5 == 0)
                return "Loza ";
            if (number % 7 == 0)
                return "Woza ";
            if (number % 11 == 0)
            {
                return Environment.NewLine + number;
            }
            return number + " ";
        }
    }
}
