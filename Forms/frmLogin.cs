using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoggyDaycare.Exceptions;
using DoggyDaycare.Managers;

namespace DoggyDaycare.Forms
{
    public partial class frmLogin : Form
    {
        private readonly string loadOption = "Close";
        private frmMain mainForm = Application.OpenForms.OfType<frmMain>().FirstOrDefault();
        private frmDashboard dashboard;
        private UserSessionManager session = UserSessionManager.GetInstance();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblUsername.Text = "User Name: ";
            lblPassword.Text = "Password: ";

            string username = txtUsername.Text;
            string password = txtPassword.Text;

            try
            {
                session.AuthenticateUser(username, password);

                lblUsername.Text = "User Name: ";
                lblPassword.Text = "Password: ";

                txtUsername.Text = string.Empty;
                txtPassword.Text = string.Empty;

                session.isLoggedIn = true;
                session.isLoginInProgress = false;

                dashboard = new frmDashboard();
                mainForm.OpenChildForm(dashboard, loadOption);
            }
            catch (UserNotFoundException ex)
            {
                lblUsername.Text += ex.Message;
            }
            catch (PasswordMismatchException ex)
            {
                lblPassword.Text += ex.Message;
            }
        }
    }
}
