using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoggyDaycare.Services;

namespace DoggyDaycare.Forms
{
    public partial class frmMain : Form
    {
        private string loadOption = "None";
        private Form activeForm;
        private frmLogin loginForm;
        private UserSession session = UserSession.GetInstance();

        private bool isMenuCollapsed = true;
        private bool isAdminButtonCollapsed = true;


        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            HideMenu();
            HideQuickAccess();
            ResizeWindow(850, 550);

            if (loginForm == null || loginForm.IsDisposed)
            {
                loginForm = new frmLogin();
            }

            OpenChildForm(loginForm, loadOption);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (isMenuCollapsed == true)
            {
                ExpandMenu();
                isMenuCollapsed = false;
            }
            else
            {
                CollapseMenu();
                isMenuCollapsed = true;
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            if (session.GetCurrentUser() == "admin")
            {
                if (isAdminButtonCollapsed == true && isMenuCollapsed == false)
                {
                    ExpandAdminButton();
                }
                else if (isAdminButtonCollapsed == false)
                {
                    CollapseAdminButton();
                }
            }
            else
            {
                MessageBox.Show("You do not have permission to access this section.",
                                "Access Denied",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            loginForm = new frmLogin();
            loadOption = "Close";

            session.isLoggedIn = false;
            session.isLoginInProgress = true;

            OpenChildForm(loginForm, loadOption);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("You are about to exit Doggy Daycare.\nWould you like to procced?",
                                                    "Exit Application",
                                                    MessageBoxButtons.OKCancel,
                                                    MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        internal void OpenChildForm(Form childForm, String option)
        {
            switch (option)
            {
                case "Close":
                    activeForm.Close();
                    break;
                case "Hide":
                    activeForm.Hide();
                    break;
                case "None":
                    // Do nothing
                    break;
            }

            if (session.isLoggedIn == false && session.isLoginInProgress == true)
            {
                HideMenu();
                HideQuickAccess();
                ResizeWindow(850, 550);
            }
            else if (session.isLoggedIn == true && session.isLoginInProgress == false)
            {
                ShowMenu();
                ShowQuickAccess();
                ResizeWindow(1206, 700);
            }

            activeForm = childForm;
            childForm.Dock = DockStyle.Fill;
            childForm.TopLevel = false;

            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(childForm);
            childForm.Show();
        }

        private void HideMenu()
        {
            pnlMenu.Visible = false;
            pnlMenu.Width = 0;
        }

        private void ShowMenu()
        {
            pnlMenu.Visible = true;
            CollapseMenu();
            // pnlMenu.Width = 175;
        }

        private void HideQuickAccess()
        {
            pnlQuickAccess.Visible = false;
            pnlQuickAccess.Height = 0;
        }

        private void ShowQuickAccess()
        {
            pnlQuickAccess.Visible = true;
            pnlQuickAccess.Height = 40;
        }

        private void ResizeWindow(int weigth, int height)
        {
            this.Size = new Size(weigth, height);
            this.CenterToScreen();
        }

        private void ExpandMenu()
        {
            btnMenu.Text = " Menu";
            btnDashboard.Text = " Dashboard";
            btnBookings.Text = " Bookings";
            btnCustomers.Text = " Customers";
            btnPets.Text = " Pets";
            btnServices.Text = " Services";
            btnAdmin.Text = " Admin";
            btnLogOut.Text = " Log Out";
            btnExit.Text = " Exit";
            pnlMenu.Width = 175;

            isMenuCollapsed = false;
        }

        private void CollapseMenu()
        {
            CollapseAdminButton();

            btnMenu.Text = "";
            btnDashboard.Text = "";
            btnBookings.Text = "";
            btnCustomers.Text = "";
            btnPets.Text = "";
            btnServices.Text = "";
            btnAdmin.Text = "";
            btnLogOut.Text = "";
            btnExit.Text = "";
            pnlMenu.Width = 38;

            isMenuCollapsed = true;
        }

        private void ExpandAdminButton()
        {
            btnReportDailyBookings.Visible = true;
            btnReportCustomerBookings.Visible = true;

            pnlAdminButton.Height = 135;

            isAdminButtonCollapsed = false;
        }

        private void CollapseAdminButton()
        {
            btnReportDailyBookings.Visible = false;
            btnReportCustomerBookings.Visible = false;

            pnlAdminButton.Height = 35;

            isAdminButtonCollapsed = true;
        }

    }
}
