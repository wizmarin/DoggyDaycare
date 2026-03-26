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
using DoggyDaycare.Services;

namespace DoggyDaycare.Forms
{
    public partial class frmLogin : Form
    {
        private readonly String loadOption = "Close";
        private frmMain mainForm = Application.OpenForms.OfType<frmMain>().FirstOrDefault();
        private frmDashboard dashboard;
        private UserSession session = UserSession.GetInstance();

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

        private void frmLogin_Load(object sender, EventArgs e)
        {
            session.isLoggedIn = false;
            session.isLoginInProgress = true;
        }
    }
}
