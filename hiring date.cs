using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_opp01
{
    internal class hiring_date
    {
        public int Day { get; set;}
        public int Month { get; set;}
        public int Year { get; set; }

        public hiring_date(int day , int month,int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public override string ToString()
        {
            return $"{Day}/{Month}/ {Year}";
        }

    }
}
