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
    public partial class frmAddService : Form
    {
        public frmAddService()
        {
            InitializeComponent();
        }

        private void frmAddService_Load(object sender, EventArgs e)
        {
            txtServiceName.Text = string.Empty;
            cmbBreedType.SelectedIndex = 1;
            nudPrice.Value = 0;
            nudMaxCapacity.Value = 0;
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            ServiceManager.AddService(txtServiceName.Text, cmbBreedType.SelectedItem.ToString(), (float)nudPrice.Value, (int)nudMaxCapacity.Value);
        }

    }
}
