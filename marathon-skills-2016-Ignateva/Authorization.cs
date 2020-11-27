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
    public partial class Authorization : Form
    {
        //Добавить файл подключения к БД

        string login = string.Empty;
        string password = string.Empty;

        //string userRole;

        DataBase dataBase = new DataBase();

        public Authorization()
        {
            InitializeComponent();

            //userRole = role;

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
            login = textBoxEmail.Text;
            password = textBoxPassword.Text;

            if (login == string.Empty)
            {
                MessageBox.Show("Пожалуйста, введите Ваш Email");
            }
            else if (password == string.Empty)
            {
                MessageBox.Show("Пожалуста, введите Ваш пароль");
            }
            else
            {
                AuthorizationRole authorizationRole = new AuthorizationRole(login, password);
                authorizationRole.Show();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
    }
}
