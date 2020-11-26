using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace marathon_skills_2016_Ignateva
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();

            Timer timer = new Timer();
            timer.Enabled = true;
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer_Tick);

            DateTime now = DateTime.Now;
            DateTime D = new DateTime(1, 11, 05, 15, 48, 00);
            DateTime B;
            if (now.Month < D.Month)
                B = D.AddYears(now.Year - 1);
            else
                B = D.AddYears(now.Year);
            TimeSpan f = B - now;
            Console.WriteLine("Осталось {0} д, {1} ч, {2} мин, {3} сек", f.Days, f.Hours, f.Minutes, f.Seconds);
            labelTimer.Text = "Осталось " + f.Days + " д, " + f.Hours + " ч, " + f.Minutes + " мин, " + f.Seconds + " сек";

        }

        void timer_Tick(object sender, EventArgs e)
        {
            int year_startDate, mounth_startDate, day_startDate, hour_startDate, minute_startDate;
            int year_count, mounth_count, day_count, hour_count, minute_count;

            int year_endDate = 2020;
            int day_endDate = 23;
            int mounth_endDate = 12;
            int hour_endDate = 0;
            int minute_endDate = 0;

            year_startDate = Convert.ToInt32(DateTime.Now.ToString("yyyy"));
            mounth_startDate = Convert.ToInt32(DateTime.Now.ToString("MM"));
            day_startDate = Convert.ToInt32(DateTime.Now.ToString("dd"));
            hour_startDate = Convert.ToInt32(DateTime.Now.ToString("HH"));
            minute_startDate = Convert.ToInt32(DateTime.Now.ToString("mm"));

            labelTestYear.Text = Convert.ToString(year_startDate);
            labelTestMounth.Text = Convert.ToString(mounth_startDate);
            labelTestDay.Text = Convert.ToString(day_startDate);

            if (year_endDate - year_startDate == 0)
            {
                if (mounth_endDate - mounth_startDate == 0)
                {
                    if (day_endDate - day_startDate == 0)
                    {
                        labelTimer.Text = string.Format("Марафон уже сегодня!!! ", DateTime.Now.ToString("yyyy.MM.dd, HH.mm.ss"));
                    }
                }
                else if (mounth_endDate - mounth_startDate > 1)
                {
                    mounth_count = mounth_endDate - mounth_startDate;
                    day_count = mounth_count * 30 + (day_endDate - day_startDate);
                    hour_count = day_count * 24 + (hour_endDate - hour_startDate);
                    minute_count = hour_count * 60 + (minute_endDate - minute_startDate);
                    minute_count / 30 / 24 % 60

                    labelTimer.Text = string.Format(mounth_count + " месяцев, " + day_count + " дней, " + hour_count + " часов и " + minute_count + " минут до старта марафона!");
                }
            }
            else if (year_endDate - year_startDate > 1)
            {

            }
            else if (year_endDate - year_startDate < 1)
            {

            }

            labelTimer.Text = string.Format("Текущее время: {0}", DateTime.Now.ToString("yyyy.MM.dd, HH.mm.ss"));
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Authorization authorization = new Authorization();
            this.Hide();
            authorization.Show();
        }

        private void btnRunner_Click(object sender, EventArgs e)
        {

        }

        private void btnSponsorship_Click(object sender, EventArgs e)
        {

        }

        private void btnGuest_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
