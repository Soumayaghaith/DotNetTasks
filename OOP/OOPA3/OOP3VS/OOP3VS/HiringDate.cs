using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3VS
{
    internal class HiringDate
    {
        public int day { get; set; }
        public int month { get; set; }
        public int year { get; set; }

        public override string ToString()
        {
            return $"{day:00}/{month:00}/{year}";
        }

        public int CompareTo(HiringDate InputDate)
        {
            
                 
            if (year != InputDate.year)
            { 
                return year.CompareTo(InputDate.year);
            }
            if (month != InputDate.month)
            { 
                return month.CompareTo(InputDate.month);
            }
            if (day != InputDate.day) 
            {
                return day.CompareTo(InputDate.day);
            }
            return -1; 

        }
    }
}
