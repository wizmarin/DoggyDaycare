using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoggyDaycare.Forms;

namespace DoggyDaycare
{
    public partial class frmMain : Form
    {
        private readonly string loadOption = "None";
        internal static Panel pnlMain;
        private Form activeForm;
        private frmLogin loginForm;

        public frmMain()
        {
            InitializeComponent();
            pnlMain = pnlMainPanel;
        }

        internal void OpenChildForm(Form childForm, string option)
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

            activeForm = childForm;
            childForm.Dock = DockStyle.Fill;
            childForm.TopLevel = false;

            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(childForm);
            childForm.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (loginForm == null || loginForm.IsDisposed)
            {
                loginForm = new frmLogin();
            }

            OpenChildForm(loginForm, loadOption);
        }
    }
}
