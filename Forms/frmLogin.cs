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

            UserSession session = UserSession.GetInstance();

            try
            {
                session.AuthenticateUser(username, password);

                lblUsername.Text = "User Name: ";
                lblPassword.Text = "Password: ";

                txtUsername.Text = string.Empty;
                txtPassword.Text = string.Empty;
                
                MessageBox.Show("Login successful!");
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
