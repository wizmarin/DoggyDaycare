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
        private readonly String loadOption = "None";
        private Form activeForm;
        private frmLogin loginForm;
        private UserSession session = UserSession.GetInstance();
        
        // internal bool isLoggedIn { get; set; }

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            HidePanel(pnlQuickAccess);
            HideMenu(flpMenu);
            ResizeWindow(850, 550);

            if (loginForm == null || loginForm.IsDisposed)
            {
                loginForm = new frmLogin();
            }

            OpenChildForm(loginForm, loadOption);
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

            if (session.isLoggedIn == true && session.isLoginInProgress == true)
            {
                ShowPanel(pnlQuickAccess);
                ShowMenu(flpMenu);
                ResizeWindow(1206, 700);
                session.isLoginInProgress = false;
            }

            if (session.isLoggedIn == false && session.isLoginInProgress == true)
            {
                HidePanel(pnlQuickAccess);
                HideMenu(flpMenu);
                ResizeWindow(850, 550);
            }

            activeForm = childForm;
            childForm.Dock = DockStyle.Fill;
            childForm.TopLevel = false;

            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(childForm);
            childForm.Show();
        }

        private void HidePanel(Panel panel)
        {
            panel.Visible = false;
            panel.Height = 0;
        }

        private void ShowPanel(Panel panel)
        {
            panel.Visible = true;
            panel.Height = 48;
        }

        private void HideMenu(FlowLayoutPanel panel)
        {
            panel.Visible = false;
            panel.Width = 0;
        }

        private void ShowMenu(FlowLayoutPanel panel)
        {
            panel.Visible = true;
            panel.Width = 200;
        }

        private void ResizeWindow(int weigth, int height)
        {
            this.Size = new Size(weigth, height);
            this.CenterToScreen();
        }
    }
}
