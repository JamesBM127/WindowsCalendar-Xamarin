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


        private void SetText()
        {
            //Date date = new Date(DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
            Date date = new Date(23, 4, 2021);

            CalendarInterface cInterface = new CalendarInterface(date);

            int a = 1;
            int start= cInterface.DaysInterfaceConfiguration() - 1;

            d01.Text = a++.ToString();
            d02.Text = a++.ToString();
            d03.Text = a++.ToString();
            d04.Text = a++.ToString();
            d05.Text = a++.ToString();

            if (start <= 6)
            {
                if (start >= 0)
                {
                    d00.Text = " ";
                    if (start >= 1)
                    {
                        d01.Text = " ";
                        if (start >= 2)
                        {
                            d02.Text = " ";
                            if (start >= 3)
                            {
                                d03.Text = " ";
                                if (start >= 4)
                                {
                                    d04.Text = " ";
                                    if (start >= 5)
                                    {
                                        d05.Text = " ";
                                    }
                                }
                            }
                        }
                    }
                }
            }

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
            d40.Text = a++.ToString();
            d41.Text = a++.ToString();
            d42.Text = a++.ToString();
            d43.Text = a++.ToString();
            d44.Text = a++.ToString();
            d45.Text = a++.ToString();
            d46.Text = a++.ToString();
            d50.Text = a++.ToString();
            d51.Text = a++.ToString();
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
                DayOfTheWeek.Text = Date.DayOfWeek + ", " + Date.ToString("dd") + " de " + Date.ToString("MMMM") + " de " + Date.ToString("yyyy");
                MonthAndYear.Text = Date.ToString("MMMM") + " de " + Date.ToString("yyyy");

                return true;
            });
        }

        public MainPage()
        {
            InitializeComponent();

            CultureInfo.CurrentCulture = new CultureInfo("pt-BR", false);

            TodayFunc();
            SetText();

        }

        private void Btn_GoToLastMonth(object sender, EventArgs e)
        {
            
        }

        private void Btn_GoToNextMonth(object sender, EventArgs e)
        {
            
        }
    }
}
