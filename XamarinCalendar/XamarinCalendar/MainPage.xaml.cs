using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Globalization;
using Xamarin.Forms;
using XamarinCalendar.Entities;

namespace XamarinCalendar
{
    public partial class MainPage : ContentPage
    {
        public DateTime Date { get; set; }
        Date date;

        //All days texts in SetText()
        private void SetText(int day, int month, int year)
        {
            //Date date = new Date(DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
            date = new Date(day, month, year);
            
            /*
            string dateString =
                date.Day.ToString() + "/" +
                date.Month.ToString() + "/" +
                date.Year.ToString();
            */

            MonthAndYear.Text = date.ToShow.ToString("MMMM") + " de " + date.ToShow.ToString("yyyy");

            CalendarInterface cInterface = new CalendarInterface(date);

            int a = 1;
            int start = cInterface.DaysInterfaceConfiguration();

            //d00 = day[0,0] // d01 = day[0,1] ... in an multi vector

            int lastDayOfMonth = DateTime.DaysInMonth(date.Year, date.Month);

            int lastMonthDays = 0;
            if (date.Month == 1)
                lastMonthDays = DateTime.DaysInMonth(date.Year - 1, 12);
            else
                lastMonthDays = DateTime.DaysInMonth(date.Year, date.Month - 1);

            a = lastMonthDays + 1;
            if (start >= 0)
            {
                a--;
                if (start >= 1)
                {    
                    a--;
                    if (start >= 2)
                    {       
                        a--;
                        if (start >= 3)
                        {       
                            a--;
                            if (start >= 4)
                            {       
                                a--;
                                if (start >= 5)
                                {       
                                    a--;
                                    if (start == 6)
                                    {       
                                        a--;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            
            if (lastMonthDays < a) a = 1;
            if (a > 20)
                d00.TextColor = Color.FromHex("#727272");
            else
                d00.TextColor = Color.FromHex("#FFFFFF");
            d00.Text = a++.ToString();

            if (lastMonthDays < a) a = 1;
            if (a > 20)
                d01.TextColor = Color.FromHex("#727272");
            else
                d01.TextColor = Color.FromHex("#FFFFFF");
            d01.Text = a++.ToString();

            if (lastMonthDays < a) a = 1;
            if (a > 20)
                d02.TextColor = Color.FromHex("#727272");
            else
                d02.TextColor = Color.FromHex("#FFFFFF");
            d02.Text = a++.ToString();

            if (lastMonthDays < a) a = 1;
            if (a > 20)
                d03.TextColor = Color.FromHex("#727272");
            else
                d03.TextColor = Color.FromHex("#FFFFFF");
            d03.Text = a++.ToString();

            if (lastMonthDays < a) a = 1;
            if (a > 20)
                d04.TextColor = Color.FromHex("#727272");
            else
                d04.TextColor = Color.FromHex("#FFFFFF");
            d04.Text = a++.ToString();

            if (lastMonthDays < a) a = 1;
            if (a > 20)
                d05.TextColor = Color.FromHex("#727272");
            else
                d05.TextColor = Color.FromHex("#FFFFFF");
            d05.Text = a++.ToString();

            if (lastMonthDays < a) a = 1;
            d06.Text = a++.ToString();

            d10.Text = a++.ToString();
            d11.Text = a++.ToString();
            d12.Text = a++.ToString();
            d13.Text = a++.ToString();
            d14.Text = a++.ToString();
            d15.Text = a++.ToString();
            d16.Text = a++.ToString();

            d20.Text = a++.ToString();
            d21.Text = a++.ToString();
            d22.Text = a++.ToString();
            d23.Text = a++.ToString();
            d24.Text = a++.ToString();
            d25.Text = a++.ToString();
            d26.Text = a++.ToString();

            d30.Text = a++.ToString();
            d31.Text = a++.ToString();
            d32.Text = a++.ToString();
            d33.Text = a++.ToString();
            d34.Text = a++.ToString();
            d35.Text = a++.ToString();
            d36.Text = a++.ToString();

            if (lastDayOfMonth < a) a = 1;
            if (a < 20)
                d40.TextColor = Color.FromHex("#727272");
            else
                d40.TextColor = Color.FromHex("#FFFFFF");
            d40.Text = a++.ToString();

            if (lastDayOfMonth < a) a = 1;
            if (a < 20)
                d41.TextColor = Color.FromHex("#727272");
            else
                d41.TextColor = Color.FromHex("#FFFFFF");
            d41.Text = a++.ToString();

            if (lastDayOfMonth < a) a = 1;
            if (a < 20)
                d42.TextColor = Color.FromHex("#727272");
            else
                d42.TextColor = Color.FromHex("#FFFFFF");
            d42.Text = a++.ToString();

            if (lastDayOfMonth < a) a = 1;
            if (a < 20)
                d43.TextColor = Color.FromHex("#727272");
            else
                d43.TextColor = Color.FromHex("#FFFFFF");
            d43.Text = a++.ToString();
            if (lastDayOfMonth < a) a = 1;
            if (a < 20)
                d44.TextColor = Color.FromHex("#727272");
            else
                d44.TextColor = Color.FromHex("#FFFFFF");
            d44.Text = a++.ToString();

            if (lastDayOfMonth < a) a = 1;
            if (a < 20)
                d45.TextColor = Color.FromHex("#727272");
            else
                d45.TextColor = Color.FromHex("#FFFFFF");
            d45.Text = a++.ToString();

            if (lastDayOfMonth < a) a = 1;
            if (a < 20)
                d46.TextColor = Color.FromHex("#727272");
            else
                d46.TextColor = Color.FromHex("#FFFFFF");
            d46.Text = a++.ToString();

            //======================================================================//

            if (lastDayOfMonth < a) a = 1;
            if (a < 20)
                d50.TextColor = Color.FromHex("#727272");
            else
                d50.TextColor = Color.FromHex("#FFFFFF");
            d50.Text = a++.ToString();

            if (lastDayOfMonth < a) a = 1;
            if (a < 20)
                d51.TextColor = Color.FromHex("#727272");
            else
                d51.TextColor = Color.FromHex("#FFFFFF");
            d51.Text = a++.ToString();

            if (lastDayOfMonth < a) a = 1;
            d52.Text = a++.ToString();
            d53.Text = a++.ToString();
            d54.Text = a++.ToString();
            d55.Text = a++.ToString();
            d56.Text = a++.ToString();

        }

        private void TodayFunc()
        {
            this.Date = DateTime.Now;

            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                this.Date = DateTime.Now;

                Hour.Text = Date.ToString("HH:mm:ss");
                DayOfTheWeek.Text = CalendarInterface.DaysInPortuguese(Date.DayOfWeek.ToString()) + ", " + Date.ToString("dd") + " de " + Date.ToString("MMMM") + " de " + Date.ToString("yyyy");

                return true;
            });
        }

        public MainPage()
        {
            InitializeComponent();

            CultureInfo.CurrentCulture = new CultureInfo("pt-BR", false);

            TodayFunc();
            SetText(DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);

        }

        private void Btn_GoToLastMonth(object sender, EventArgs e)
        {
            if(date.Month == 1)
            {
                SetText(date.Day, 12, date.Year - 1);
            }
            else
            {
                SetText(date.Day, date.Month - 1, date.Year);
            }
        }

        private void Btn_GoToNextMonth(object sender, EventArgs e)
        {
            if (date.Month == 12)
            {
                SetText(date.Day, 1, date.Year + 1);
            }
            else
            {
                SetText(date.Day, date.Month + 1, date.Year);
            }
        }
    }
}
