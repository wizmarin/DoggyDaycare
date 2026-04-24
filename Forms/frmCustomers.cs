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
    public partial class frmCustomers : Form
    {
        private UserSessionManager session = UserSessionManager.GetInstance();
        private bool _isDataLoading = false;
        private Customer selected;
        private List<Customer> dataSource;
        private List<Pet> pets;

        public frmCustomers()
        {
            InitializeComponent();
        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            _isDataLoading = true;

            if (session.GetCurrentUser() != "admin")
            {
                btnDeactivate.Enabled = false;
            }

            LoadAllCustomers();
            _isDataLoading = false;
        }

        private void dgvResult_SelectionChanged(object sender, EventArgs e)
        {
            if (_isDataLoading) return;

            if (dgvResult.SelectedRows.Count == 0)
            {
                ClearLabels();
                selected = new Customer();
                return;
            }

            selected = (Customer)dgvResult.SelectedRows[0].DataBoundItem;

            lblCustomerID.Text = $"Customer ID: {selected.Id}";
            lblCustomerName.Text = $"Full Name: {selected.FullName}";
            lblEmail.Text = $"Email: {selected.Email}";
            lblPhone.Text = $"Phone: {selected.PhoneNumberDisplay(selected.PhoneNumber)}";
            lblEmergencyContact.Text = $"Emergency Contact: {selected.EmergencyContactNameDisplay(selected.EmergencyContactName)}";
            lblEmergencyContactPhone.Text = $"Emergency Contact Phone: {selected.PhoneNumberDisplay(selected.EmergencyContactPhone)}";
            lblPets.Text = "";

            pets = PetManager.GetPetsByOwnerId(selected.Id);
            lblPets.Text = string.Join(", ", pets.Select(p => p.Name));
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // TODO: Implement search functionality based on user input
        }

        private void btnUpdateInformation_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerManager.LoadUpdateForm(selected);
            }
            catch (NoSelectionException ex)
            {
                MessageBox.Show(ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeactivate_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerManager.DeactivateCustomer(selected);
                _isDataLoading = true;
                UpdateDataSource(selected, "deactivate");
                _isDataLoading = false;
            }
            catch (NoSelectionException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (DeactivationAbortedException ex)
            {
                MessageBox.Show(ex.Message, "Deactivation Aborted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LoadAllCustomers()
        {
            dataSource = CustomerManager.GetAllCustomers();
            dgvResult.DataSource = dataSource;
            FormatDataView();
        }

        internal void UpdateDataSource(Customer customer, string option)
        {
            if (option == "update")
            {
                int index = dataSource.FindIndex(c => c.Id == customer.Id);
                if (index != -1)
                {
                    dataSource[index] = customer;
                }
            }
            else if (option == "deactivate")
            {
                dataSource.RemoveAll(c => c.Id == customer.Id);
            }

            dgvResult.DataSource = null;
            dgvResult.DataSource = dataSource;
            FormatDataView();
        }

        private void FormatDataView()
        {
            dgvResult.Columns["Status"].Visible = false;

            dgvResult.Columns["Id"].HeaderText = "ID";
            dgvResult.Columns["FullName"].HeaderText = "Full Name";
            dgvResult.Columns["PhoneNumber"].HeaderText = "Phone";
            dgvResult.Columns["EmergencyContactName"].HeaderText = "Emerg. Contact";
            dgvResult.Columns["EmergencyContactPhone"].HeaderText = "Emerg. Contact Phone";

            dgvResult.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvResult.Columns["FullName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvResult.Columns["PhoneNumber"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvResult.Columns["Email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvResult.Columns["EmergencyContactName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvResult.Columns["EmergencyContactPhone"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void ClearLabels()
        {
            lblCustomerID.Text = "Customer ID: ";
            lblCustomerName.Text = "Full Name: ";
            lblEmail.Text = "Email: ";
            lblPhone.Text = "Phone: ";
            lblEmergencyContact.Text = "Emergency Contact: ";
            lblEmergencyContactPhone.Text = "Emergency Contact Phone: ";
            lblPets.Text = "";
        }

    }
}
