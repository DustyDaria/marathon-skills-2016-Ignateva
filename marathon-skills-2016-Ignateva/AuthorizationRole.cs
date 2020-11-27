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
    public partial class AuthorizationRole : Form
    {
        DataBase dataBase = new DataBase();

        string userLogin = string.Empty;
        string userPassword = string.Empty;

        string queryRoleTest = string.Empty;

        public AuthorizationRole(string login, string password)
        {
            InitializeComponent();

            userLogin = login;
            userPassword = password;

            queryRoleTest = string.Format("SELECT RoleId FROM Users WHERE Email = '" + userLogin + "' AND Password = '" + userPassword + "';");
        }

        private void btnRunner_Click(object sender, EventArgs e)
        {
            if ("R" == dataBase.getResultString(queryRoleTest))
            {
                RunnerMenu runnerMenu = new RunnerMenu();
                this.Close();
                runnerMenu.Show();
            }
            else
            {
                MessageBox.Show("ОШИБКА!\nНекорректные данные для входа");
                this.Close();
            }
        }
        private void btnCoordinator_Click(object sender, EventArgs e)
        {
            if ("C" == dataBase.getResultString(queryRoleTest))
            {
                CoordinatorMenu coordinatorMenu = new CoordinatorMenu();
                this.Close();
                coordinatorMenu.Show();
            }
            else
            {
                MessageBox.Show("ОШИБКА!\nНекорректные данные для входа");
                this.Close();
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            if ("A" == dataBase.getResultString(queryRoleTest))
            {
                AdministratorMenu administratorMenu = new AdministratorMenu();
                this.Close();
                administratorMenu.Show();
            }
            else
            {
                MessageBox.Show("ОШИБКА!\nНекорректные данные для входа");
                this.Close();
            }
        }
    }
}
