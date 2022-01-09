using Date.Tests.Exception;

namespace Exercise5
{
    public class Date
    {
        public int _day, _month, _year;

        public Date(int month, int day, int year)
        {
            if (day is < 1 or > 31 || month is < 1 or > 12 || year is < 1 or > 2022)
                throw new InvalidDateException();

            _day = day;
            _month = month;
            _year = year;
        }

        public string DisplayDate()
        {
            return $"{_day} / {_month} / {_year}";
        }
    }
}

