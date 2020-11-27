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

            DateTime now = DateTime.Now;
            DateTime D = new DateTime(1, 12, 23, 10, 00, 00);
            DateTime B;
            if (now.Month < D.Month)
                B = D.AddYears(now.Year - 1);
            else
                B = D.AddYears(now.Year);
            TimeSpan f = B - now;
            labelTimer.Text = "Осталось " + f.Days + " дней, " + f.Hours + " часов, и " + f.Minutes + " минут  до старта марафона";

        }

        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Authorization authorization = new Authorization();
            this.Hide();
            authorization.Show();
        }

        private void btnRunner_Click(object sender, EventArgs e)
        {
            RegisterRunner_FirstScreen registerRunner_FirstScreen = new RegisterRunner_FirstScreen();
            this.Hide();
            registerRunner_FirstScreen.Show();
        }

        private void btnSponsorship_Click(object sender, EventArgs e)
        {
            SponsorRunner sponsorRunner = new SponsorRunner();
            this.Hide();
            sponsorRunner.Show();
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            Information information = new Information();
            this.Hide();
            information.Show();
        }

    }
}
