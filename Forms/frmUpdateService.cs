using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoggyDaycare.Models;
using DoggyDaycare.Managers;

namespace DoggyDaycare.Forms
{
    public partial class frmUpdateService : Form
    {
        private Service service;

        public frmUpdateService(Service service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void frmUpdateService_Load(object sender, EventArgs e)
        {
            txtServiceName.Text = service.Name;
            cmbBreedType.Text = service.BreedType;
            nudPrice.Value = (decimal)service.PricePerHour;
            nudMaxCapacity.Value = service.MaxCapacityPerSlot;
        }

        private void btnUpdateService_Click(object sender, EventArgs e)
        {
            ServiceManager.UpdateService(service, txtServiceName.Text, cmbBreedType.Text, (float)nudPrice.Value, (int)nudMaxCapacity.Value);
        }
    }
}
