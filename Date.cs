using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Malind_Assignment_10_6
{
    class Date
    {
        private int month;
        private int day;
        private int year;

        //auto-implemented property year
        public int Year 
        { 
            get
            {
                return year;
            }
            private set
            {
                if (value > 0)
                    year = value;
                else //year is invalid
                    throw new ArgumentOutOfRangeException("Year", value, "Year must be greater than 0");
            }
        }

        //constructor: use property Month to confirm proper value for month;
        //use property Day to confirm proper value for day
        public Date(int theMonth, int theDay, int theYear)
        {
            Month = theMonth; //validate the month
            Year = theYear; //could validate year
            Day = theDay; //validate day
            Console.WriteLine("Date object constructor for date {0}", this);
        }//end Date constructor

        public int Month
        {
            get
            {
                return month;
            }//end get
            private set //make writing inaccessible outside the class
            {
                if (value > 0 && value <= 12) //validate month
                    month = value;
                else //month is invalid
                    throw new ArgumentOutOfRangeException("Month", value, "Month must be 1-12");
            }//end set
        }//end property Month

        //property that gets and sets the day
        public int Day
        {
            get
            {
                return day;
            }//end get
            private set //make writing inaccessible outside the class
            {
                int [] daysPerMonth = {0,31,28,31,30,31,30,31,31,30,31,30,31};

                //check if day in range for month
                if (value > 0 && value <= daysPerMonth[Month])
                    day = value;
                //check for leap year
                else if (Month == 2 && value == 29 && (Year % 400 == 0 || (Year % 4 == 0 && Year % 100 != 0)))
                    day = value;
                else //day is invalid
                    throw new ArgumentOutOfRangeException("Day", value, "Day out of range for current month/year");
            }//end set 
        }//end property Day

        //return a string of the form month/day/year
        public override string ToString()
        {
            return string.Format("{0}/{1}/{2}", Month, Day, Year);
        }//end method ToString


        //NextDay Method
        public int NextDay()
        {
            return Day++;
        }


    }//end class Date
}
