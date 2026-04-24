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
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            LoadSmallServices();
            LoadMediumServices();
            LoadBigServices();
        }

        private void LoadSmallServices()
        {
            dgvSmallServices.DataSource = ServiceManager.GetSmallBreed();

            dgvSmallServices.Columns["Id"].Visible = false;
            dgvSmallServices.Columns["Status"].Visible = false;
            dgvSmallServices.Columns["BreedType"].Visible = false;
            dgvSmallServices.Columns["Display"].Visible = false;
            dgvSmallServices.Columns["MaxCapacityPerSlot"].Visible = false;

            dgvSmallServices.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvSmallServices.Columns["PricePerHour"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvSmallServices.Columns["PricePerHour"].HeaderText = "Price";
        }

        private void LoadMediumServices()
        {
            dgvMediumServices.DataSource = ServiceManager.GetMediumBreed();
            
            dgvMediumServices.Columns["Id"].Visible = false;
            dgvMediumServices.Columns["Status"].Visible = false;
            dgvMediumServices.Columns["BreedType"].Visible = false;
            dgvMediumServices.Columns["Display"].Visible = false;
            dgvMediumServices.Columns["MaxCapacityPerSlot"].Visible = false;

            dgvMediumServices.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvMediumServices.Columns["PricePerHour"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvMediumServices.Columns["PricePerHour"].HeaderText = "Price";
        }

        private void LoadBigServices()
        {
            dgvBigServices.DataSource = ServiceManager.GetBigBreed();
            
            dgvBigServices.Columns["Id"].Visible = false;
            dgvBigServices.Columns["Status"].Visible = false;
            dgvBigServices.Columns["BreedType"].Visible = false;
            dgvBigServices.Columns["Display"].Visible = false;
            dgvBigServices.Columns["MaxCapacityPerSlot"].Visible = false;

            dgvBigServices.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvBigServices.Columns["PricePerHour"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvBigServices.Columns["PricePerHour"].HeaderText = "Price";
        }
    }
}
