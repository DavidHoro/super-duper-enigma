using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    class Date
    {
        private int day;
        private int month;
        private int year;

        public int Day { get => day; set => day = value; }
        public int Month { get => month; set => month = value; }
        public int Year { get => year; set => year = value; }

        public Date(int d, int m, int y)
        {
            day = d;
            month = m;
            Year = y;
        }
    }
}
