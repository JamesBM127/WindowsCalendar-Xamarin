using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using Xamarin.Forms;

namespace XamarinCalendar
{
    public partial class MainPage : ContentPage
    {
        public DateTime Date { get; set; }

        private void TodayFunc()
        {
            this.Date = DateTime.Now;

            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                this.Date = DateTime.Now;

                Hour.Text = Date.ToString("HH:mm:ss");
                DayOfTheWeek.Text = Date.DayOfWeek.ToString() + ", " + Date.ToString("dd") + " de " + Date.ToString("MMMM") + " de " + Date.ToString("yyyy");
                return true;
            });
        }

        public MainPage()
        {
            InitializeComponent();

            TodayFunc();


        }
    }
}
