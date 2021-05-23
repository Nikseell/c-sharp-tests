using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    public class Date
    {
        private int _date;
        private int _month;
        private int _year;

        public Date(int date, int month, int year)
        {
            _date = date;
            _month = month;
            _year = year;
        }

        public string DisplayDate()
        {
            if (_date > 0 && _month > 0 && _year > 0)
            {
                return $"{_month}/{_date}/{_year}";
            }
            else
            {
                return "Invalid date!";
            }
        }
    }
}
