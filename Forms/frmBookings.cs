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
    public partial class frmBookings : Form
    {
        private bool _isDataLoading = false;
        private Booking selected;
        private List<Booking> dataSource;

        public frmBookings()
        {
            InitializeComponent();
        }

        private void frmBookings_Load(object sender, EventArgs e)
        {
            _isDataLoading = true;
            LoadAllBookings();
            _isDataLoading = false;


        }

        private void dgvResult_SelectionChanged(object sender, EventArgs e)
        {
            if (_isDataLoading) return;

            if (dgvResult.SelectedRows.Count == 0)
            {
                ClearLabels();
                selected = new Booking();
                return;
            }

            selected = (Booking)dgvResult.SelectedRows[0].DataBoundItem;

            lblBookingID.Text = $"Booking ID: {selected.Id}";
            lblService.Text = $"Service: {selected.ServiceDisplay(selected.ServiceId)}";
            lblCheckIn.Text = $"Check-In: {selected.CheckIn:dd/MM/yyyy HH:mm}";
            lblCheckOut.Text = $"Check-Out: {selected.CheckOut:dd/MM/yyyy HH:mm}";
            lblPricePerHour.Text = $"Price Per Hour: {selected.PricePerHour:C}";
            lblCustomer.Text = $"Customer: {selected.CustomerDisplay(selected.CustomerId)}";
            lblPet.Text = $"Pet: {selected.PetDisplay(selected.PetId)}";
            lblActualPrice.Text = $"Actual Price: {selected.ActualPrice:C}";
            lblStatus.Text = $"Status: {selected.Status}";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // TODO: Implement search functionality based on selected criteria (e.g., by customer, by pet, by date range).
        }

        private void btnUpdateInformation_Click(object sender, EventArgs e)
        {
            // TODO: Implement update information functionality, which opens a new form to edit the selected booking's details. Ensure that the form is pre-populated with the current booking information and that any changes are validated and saved back to the database.
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            // TODO: Implement check-in functionality, which updates the selected booking's status to "Checked-In" and sets the actual check-in time. Include validation to ensure that the booking is eligible for check-in (e.g., current date and time is within a certain range of the booking's check-in time).
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            // TODO: Implement check-out functionality, which updates the selected booking's status to "Checked-Out" and sets the actual check-out time. Include validation to ensure that the booking is eligible for check-out (e.g., current date and time is within a certain range of the booking's check-out time).   
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                BookingManager.CancelBooking(selected);
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
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAllBookings()
        {
            dataSource = BookingManager.GetAllBookings();
            dgvResult.DataSource = dataSource;
            FormatDataView();
        }

        internal void UpdateDataSource(Booking booking, string option)
        {
            if (option == "update")
            {
                int index = dataSource.FindIndex(b => b.Id == booking.Id);
                if (index != -1)
                {
                    dataSource[index] = booking;
                }
            }
            else if (option == "deactivate")
            {
                dataSource.RemoveAll(b => b.Id == booking.Id);
            }

            dgvResult.DataSource = null;
            dgvResult.DataSource = dataSource;
            FormatDataView();
        }

        private void FormatDataView()
        {
            dgvResult.Columns["Id"].HeaderText = "ID";
            dgvResult.Columns["ServiceId"].HeaderText = "Service ID";
            dgvResult.Columns["CustomerId"].HeaderText = "Customer ID";
            dgvResult.Columns["PetId"].HeaderText = "Pet ID";
            dgvResult.Columns["CheckIn"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            dgvResult.Columns["CheckOut"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";

            dgvResult.Columns["CheckInDate"].Visible = false;
            dgvResult.Columns["CheckOutDate"].Visible = false;
            dgvResult.Columns["CheckInTime"].Visible = false;
            dgvResult.Columns["CheckOutTime"].Visible = false;
        }

        private void ClearLabels()
        {
            lblBookingID.Text = $"Booking ID:";
            lblService.Text = $"Service:";
            lblCheckIn.Text = $"Check-In:";
            lblCheckOut.Text = $"Check-Out:";
            lblPricePerHour.Text = $"Price Per Hour:";
            lblCustomer.Text = $"Customer:";
            lblPet.Text = $"Pet:";
            lblActualPrice.Text = $"Actual Price:";
            lblStatus.Text = $"Status:";
        }
    }
}
