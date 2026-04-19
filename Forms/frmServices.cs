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
using DoggyDaycare.Models;

namespace DoggyDaycare.Forms
{
    public partial class frmServices : Form
    {
        private UserSessionManager session = UserSessionManager.GetInstance();
        private bool _isDataLoading = false;
        private Service selected;
        private List<Service> dataSource;

        public frmServices()
        {
            InitializeComponent();
        }

        private void frmServices_Load(object sender, EventArgs e)
        {
            _isDataLoading = true;

            if (session.GetCurrentUser() != "admin")
            {
                btnUpdateInformation.Enabled = false;
                btnDeactivate.Enabled = false;
            }

            LoadAllServices();
            _isDataLoading = false;
        }

        private void dgvResult_SelectionChanged(object sender, EventArgs e)
        {
            if (_isDataLoading) return;

            if (dgvResult.SelectedRows.Count == 0)
            {
                ClearLabels();
                selected = new Service();
                return;
            }

            selected = (Service)dgvResult.SelectedRows[0].DataBoundItem;

            lblServiceID.Text = $"Service ID: {selected.Id}";
            lblServiceName.Text = $"Service Name: {selected.Name}";
            lblBreedType.Text = $"Breed Type: {selected.BreedType}";
            lblPricePerHour.Text = $"Price Per Hour: {selected.PricePerHour:C}";
            lblMaxCapacityPerTimeSlot.Text = $"Max Capacity Per Time Slot: {selected.MaxCapacityPerSlot}";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // TODO: Implement search functionality based on user input
        }

        private void btnUpdateInformation_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceManager.LoadUpdateForm(selected);
            }
            catch (NoSelectionException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeactivate_Click(object sender, EventArgs e)
        {
            try 
            {
                ServiceManager.DeactivateService(selected);
                _isDataLoading = true;
                UpdateDataSource(selected, "deactivate");
                _isDataLoading = false;
            }
            catch (NoSelectionException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DeactivationAbortedException ex)
            {
                MessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LoadAllServices()
        {
            dataSource = ServiceManager.GetAllServices();
            dgvResult.DataSource = dataSource;
            FormatDataView();
        }

        internal void UpdateDataSource(Service service, string option)
        {
            if (option == "update")
            {
                int index = dataSource.FindIndex(s => s.Id == service.Id);
                if (index != -1)
                {
                    dataSource[index] = service;
                }
            }
            else if (option == "deactivate")
            {
                dataSource.RemoveAll(s => s.Id == service.Id);
            }

            dgvResult.DataSource = null;
            dgvResult.DataSource = dataSource;
            FormatDataView();
        }

        private void FormatDataView()
        {
            dgvResult.Columns["Status"].Visible = false;

            dgvResult.Columns["Id"].HeaderText = "ID";
            dgvResult.Columns["Name"].HeaderText = "Service Name";
            dgvResult.Columns["PricePerHour"].HeaderText = "Price Per Hour";
            dgvResult.Columns["BreedType"].HeaderText = "Breed Type";
            dgvResult.Columns["MaxCapacityPerSlot"].HeaderText = "Max Capacity Per Time Slot";

            dgvResult.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvResult.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvResult.Columns["PricePerHour"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvResult.Columns["BreedType"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvResult.Columns["MaxCapacityPerSlot"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void ClearLabels()
        {
            lblServiceID.Text = "Service ID: ";
            lblServiceName.Text = "Service Name: ";
            lblBreedType.Text = "Breed Type: ";
            lblPricePerHour.Text = "Price Per Hour: ";
            lblMaxCapacityPerTimeSlot.Text = "Max Capacity Per Time Slot: ";
        }
    }
}
