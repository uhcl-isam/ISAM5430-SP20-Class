using System;
using System.Collections.Generic;
using System.Text;

namespace ISAM5430.SP20.Class08
{
    class Date
    {
        // hidden / encapsulated data.
        private int _month;
        private int _day;
        private int _year;

        public Date()
        {
            Month = DateTime.Now.Month;
            Day = DateTime.Now.Day;
            Year = DateTime.Now.Year;
        }

        // copy constructor
        public Date(Date date)
        {
            _month = date._month;
            _day = date._day;
            _year = date._year;
        }

        public Date(int month, int day, int year)
        {
            Month = month;
            Day = day;
            Year = year;
        }

        public Date(int month, int year)
            : this(month, 1, year)
        {
        }

        public Date(int year)
        {
            Month = 1;
            Day = 1;
            Year = year;
        }



        public int Month {
            get
            {
                return _month;
            }
            set
            {
                if (value >= 1 && value <= 12)
                {
                    _month = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }
            }
        }

        public int Day
        {
            get
            {
                return _day;
            }
            set
            {
                if (_month == 1 || _month == 3 || _month == 5 || _month == 7 || _month == 8 || _month == 10 || _month == 12)
                {
                    if (value > 31)
                    {
                        throw new ArgumentOutOfRangeException(nameof(value));
                    }
                }
                else if (_month == 4 || _month == 6 || _month == 9 || _month == 11)
                {
                    if (value > 30)
                    {
                        throw new ArgumentOutOfRangeException(nameof(value));
                    }
                }
                else if (_month == 2)
                {
                    bool leapYear = _year % 400 != 0 ? false : _year % 4 == 0;
                    if (value > (leapYear ? 29 : 28))
                    {
                        throw new ArgumentOutOfRangeException(nameof(value));
                    }
                }
                _day = value ;

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
                if (value < 1900 || value > 2100)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }
                _year = value ;

            }
        }

        public void SetMonth(int month)
        {
            if (month >= 1 && month <= 12)
            {
                _month = month;
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(month));
            }
        }

        public void SetDay(int day)
        {
            if (_month == 1 || _month == 3 || _month == 5 || _month == 7 || _month == 8 || _month == 10 || _month == 12)
            {
                if (day > 31)
                {
                    throw new ArgumentOutOfRangeException(nameof(day));
                }
            }
            else if (_month == 4 || _month == 6 || _month == 9 || _month == 11)
            {
                if (day > 30)
                {
                    throw new ArgumentOutOfRangeException(nameof(day));
                }
            }
            else if (_month == 2)
            {
                bool leapYear = _year % 400 != 0 ? false : _year % 4 == 0;
                if (day > (leapYear ? 29 : 28))
                {
                    throw new ArgumentOutOfRangeException(nameof(day));
                }
            }
            _day = day;
        }

        public void SetYear(int year)
        {
            if (year < 1900 || year > 2100)
            {
                throw new ArgumentOutOfRangeException(nameof(year));
            }
            _year = year;
        }

        public int GetYear()
        {
            return _year;
        }

        public int GetMonth()
        {
            return _month;
        }

        public int GetDay()
        {
            return _day;
        }

        public string ToMonthDay()
        {
            return $"{Month}/{Day}";
        }

        public override string ToString()
        {
            return $"{Month}/{GetDay()}/{GetYear()}";
        }
    }
}
