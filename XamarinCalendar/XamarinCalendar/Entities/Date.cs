using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinCalendar.Entities
{
    class Date
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public DateTime ToShow { get; set; }

        public Date(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
            setDateToShow(day, month, year);
        }

        //Kind useless, but i create this function to set the date if i want in the future.
        public void setDateToShow(int day, int month, int year)
        {
            ToShow = new DateTime(year, month, day);
        }
    }
}
