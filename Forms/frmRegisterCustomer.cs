using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoggyDaycare.Managers;

namespace DoggyDaycare.Forms
{
    public partial class frmRegisterCustomer : Form
    {
        public frmRegisterCustomer()
        {
            InitializeComponent();
        }

        private void btnRegisterCustomer_Click(object sender, EventArgs e)
        {
            CustomerManager.RegisterCustomer(txtFullName.Text, txtEmail.Text, txtPhone.Text, txtEmergencyContact.Text, txtEmergencyContactPhone.Text);
        }
    }
}
