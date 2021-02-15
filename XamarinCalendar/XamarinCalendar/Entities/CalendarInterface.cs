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
                case "sunday": return 0;

                case "monday": return 1;

                case "tuesday": return 2;

                case "wednesday": return 3;

                case "thursday": return 4;

                case "friday": return 5;

                case "saturday": return 6;
            }
            return 0;
        }

    }
}
