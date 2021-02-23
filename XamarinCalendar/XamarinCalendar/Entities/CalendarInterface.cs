using System;
using System.Collections.Generic;
using System.Text;
using XamarinCalendar;

namespace XamarinCalendar.Entities
{
    class CalendarInterface
    {
        public Date Date { get; set; }

        public CalendarInterface(Date date)
        {
            Date = date;
        }

        public string FirstDayOfMonth()
        {
            DateTime firstDay = new DateTime(Date.Year, Date.Month, 1);
            return firstDay.DayOfWeek.ToString().ToLower();
        }

        public int DaysInterfaceConfiguration()
        {
            switch (FirstDayOfMonth())
            {
                case "sunday": return -1;

                case "monday": return 0;

                case "tuesday": return 1;

                case "wednesday": return 2;

                case "thursday": return 3;

                case "friday": return 4;

                case "saturday": return 5;
            }
            return 0;
        }

    }
}
