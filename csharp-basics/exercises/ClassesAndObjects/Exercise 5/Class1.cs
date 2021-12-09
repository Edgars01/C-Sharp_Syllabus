using System;

namespace Exercise_5
{
    public class Date
    {
        public int _day;
        public int _month;
        public int _year;

        public Date(int month, int day, int year)
        {
            _day = day;
            _month = month;
            _year = year;
        }

        public int Day
        { 
            get
            {
                return _day;
            }
            set
            {
                _day = value;
            }
        }

        public int Month
        {
            get
            {
                return _month;
            }
            set
            {
                _month = value;
            }
        }

        public int Year
        {
            get
            {
                return _year;
            }
            set
            {
                _year = value;
            }
        }

        public void DisplayDate()
        {
            Console.WriteLine($"{_day} / {_month} / {_year}");
        }
    }
}
