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

        public Authorization()
        {
            InitializeComponent();
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
                //НЕОБХОДИМО ПОДКЛЮЧЕНИЕ К БД
                string queryReg = "INSERT Email, Password, RoleId";

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
