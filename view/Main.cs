using AgentieDeTurismMpp.model;
using AgentieDeTurismMpp.service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgentieDeTurismMpp.view
{
    public partial class Main : Form
    {
        private LoggingService loggingService = new LoggingService();
        //private Employee employee; 

        public Main()
        {
            InitializeComponent();
        }

        private void logInEmployee(object sender, EventArgs e)
        {
            string username = usernameField.Text;
            string password = passwordField.Text;
            Employee employee = new Employee(username, password);

            bool validUser = loggingService.loginUser(employee);
            if (validUser)
            {
                this.Hide();
                SearchExcursions searchExcursions = new SearchExcursions();
                searchExcursions.ShowDialog();
            }
            else
            {
                loginAlert.Text = "Username or Password incorrect! Please type in again.";
            }
        }
    }
}
