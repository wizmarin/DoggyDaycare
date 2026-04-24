using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoggyDaycare.Managers;
using DoggyDaycare.Models;

namespace DoggyDaycare.Forms
{
    public partial class frmAddBooking : Form
    {
        private List<Customer> customers;
        private List<Pet> pets;
        private List<Service> services;
        private bool _isSearchingCustomers = false;
        private bool _isSearchingPets = false;
        private bool _isSearchingServices = false;
        private bool _isDateTimeChanging = false;
        private Customer selectedCustomer;
        private Pet selectedPet;
        private Service selectedService;

        public frmAddBooking()
        {
            InitializeComponent();
        }

        private void frmAddBooking_Load(object sender, EventArgs e)
        {
            customers = CustomerManager.GetAllCustomers();
            services = ServiceManager.GetAllServices();

            dtpCheckInDate.MinDate = DateTime.Today;
            dtpCheckInDate.Value = DateTime.Now;

            dtpCheckOutDate.MinDate = DateTime.Today;
            dtpCheckOutDate.Value = DateTime.Now;

            dtpCheckInTime.Value = new DateTime(dtpCheckInDate.Value.Year, dtpCheckInDate.Value.Month, dtpCheckInDate.Value.Day, dtpCheckInDate.Value.Hour, 0, 0).AddHours(1);
            dtpCheckOutTime.Value = new DateTime(dtpCheckOutDate.Value.Year, dtpCheckOutDate.Value.Month, dtpCheckOutDate.Value.Day, dtpCheckInDate.Value.Hour, 0, 0).AddHours(2);

            cmbCustomer.DisplayMember = "Display";
            cmbPet.ValueMember = "Id";
            cmbCustomer.DataSource = customers;
        }

        private void cmbCustomer_TextChanged(object sender, EventArgs e)
        {
            if (_isSearchingCustomers) return;

            _isSearchingCustomers = true;

            string keyword = cmbCustomer.Text;

            var filtered = string.IsNullOrWhiteSpace(keyword)
                ? customers
                : customers
                    .Where(c =>
                    {
                        string normalizedDisplay = Regex.Replace(c.Display, @"\D", "");
                        string normalizedKeyword = Regex.Replace(keyword, @"\D", "");

                        bool matchesName = c.Display.Contains(keyword, StringComparison.OrdinalIgnoreCase);
                        bool matchesPhone = !string.IsNullOrEmpty(normalizedKeyword) &&
                                            normalizedDisplay.Contains(normalizedKeyword, StringComparison.OrdinalIgnoreCase);

                        return matchesName || matchesPhone;
                    })
                    .ToList();

            cmbCustomer.DataSource = new List<Customer>(filtered);
            cmbCustomer.DisplayMember = "Display";
            cmbCustomer.ValueMember = "Id";

            cmbCustomer.Text = keyword;
            cmbCustomer.Select(keyword.Length, 0);

            if (filtered.Count > 0)
                cmbCustomer.DroppedDown = true;

            _isSearchingCustomers = false;
        }

        private void cmbCustomer_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (_isSearchingPets) return;

            _isSearchingPets = true;

            selectedCustomer = (Customer)cmbCustomer.SelectedItem;

            if (selectedCustomer == null)
            {
                _isSearchingPets = false;
                return;
            }

            pets = PetManager.GetPetsByOwnerId(selectedCustomer.Id);

            cmbPet.DataSource = null;
            cmbPet.DisplayMember = "Name";
            cmbPet.ValueMember = "Id";
            cmbPet.DataSource = pets;

            _isSearchingPets = false;
        }

        private void cmbPet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isSearchingServices) return;

            _isSearchingServices = true;

            selectedPet = (Pet)cmbPet.SelectedItem;

            if (selectedPet == null)
            {
                return;
            }

            switch (selectedPet.BreedType)
            {
                case "Small":
                    services = ServiceManager.GetSmallBreed();
                    break;
                case "Medium":
                    services = ServiceManager.GetMediumBreed();
                    break;
                case "Big":
                    services = ServiceManager.GetBigBreed();
                    break;
            }

            cmbService.DataSource = null;
            cmbService.DisplayMember = "Name";
            cmbService.ValueMember = "Id";
            cmbService.DataSource = services;

            _isSearchingServices = false;
        }

        private void dtpCheckInDate_ValueChanged(object sender, EventArgs e)
        {
            if (_isDateTimeChanging) return;

            _isDateTimeChanging = true;

            dtpCheckOutDate.MinDate = dtpCheckInDate.Value;
            dtpCheckOutDate.Value = dtpCheckInDate.Value;

            if (dtpCheckInDate.Value.Date == DateTime.Now.Date)
            {
                dtpCheckInTime.MaxDate = DateTimePicker.MaxDateTime;

                dtpCheckInTime.MinDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, 0, 0).AddHours(1);
                dtpCheckInTime.MaxDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59);
                dtpCheckInTime.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, 0, 0).AddHours(1);
            }
            else
            {
                dtpCheckInTime.MaxDate = DateTimePicker.MaxDateTime;

                dtpCheckInTime.MinDate = new DateTime(dtpCheckInDate.Value.Year, dtpCheckInDate.Value.Month, dtpCheckInDate.Value.Day, 0, 0, 0);
                dtpCheckInTime.MaxDate = new DateTime(dtpCheckInDate.Value.Year, dtpCheckInDate.Value.Month, dtpCheckInDate.Value.Day, 23, 59, 59);
                dtpCheckInTime.Value = new DateTime(dtpCheckInDate.Value.Year, dtpCheckInDate.Value.Month, dtpCheckInDate.Value.Day, 8, 0, 0);
            }

            dtpCheckOutTime.MinDate = DateTimePicker.MinDateTime;
            dtpCheckOutTime.MaxDate = DateTimePicker.MaximumDateTime;

            dtpCheckOutTime.MinDate = dtpCheckInTime.Value.AddMinutes(15);
            dtpCheckOutTime.Value = dtpCheckInTime.Value.AddHours(1);

            _isDateTimeChanging = false;
        }

        private void dtpCheckOutDate_ValueChanged(object sender, EventArgs e)
        {
            if (_isDateTimeChanging) return;

            _isDateTimeChanging = true;

            if (dtpCheckOutDate.Value.Date == dtpCheckInDate.Value.Date)
            {
                dtpCheckOutTime.MinDate = DateTimePicker.MinDateTime;
                dtpCheckOutTime.MaxDate = DateTimePicker.MaxDateTime;

                dtpCheckOutTime.MinDate = dtpCheckInTime.Value.AddMinutes(15);
                dtpCheckOutTime.MaxDate = new DateTime(dtpCheckInDate.Value.Year, dtpCheckInDate.Value.Month, dtpCheckInDate.Value.Day, 23, 59, 59);
                dtpCheckOutTime.Value = dtpCheckInTime.Value.AddHours(1);
            }
            else
            {
                dtpCheckOutTime.MinDate = DateTimePicker.MinDateTime;
                dtpCheckOutTime.MaxDate = DateTimePicker.MaxDateTime;

                dtpCheckOutTime.MinDate = new DateTime(dtpCheckOutDate.Value.Year, dtpCheckOutDate.Value.Month, dtpCheckOutDate.Value.Day, 0, 0, 0);
                dtpCheckOutTime.MaxDate = new DateTime(dtpCheckOutDate.Value.Year, dtpCheckOutDate.Value.Month, dtpCheckOutDate.Value.Day, 23, 59, 59);
                dtpCheckOutTime.Value = new DateTime(dtpCheckOutDate.Value.Year, dtpCheckOutDate.Value.Month, dtpCheckOutDate.Value.Day, 8, 0, 0);
            }

            _isDateTimeChanging = false;
        }

        private void dtpCheckInTime_ValueChanged(object sender, EventArgs e)
        {
            if (_isDateTimeChanging) return;

            _isDateTimeChanging = true;

            if (dtpCheckOutDate == dtpCheckInDate)
            {
                dtpCheckOutTime.MinDate = DateTimePicker.MinDateTime;
                dtpCheckOutTime.MaxDate = DateTimePicker.MaxDateTime;

                dtpCheckOutTime.MinDate = dtpCheckInTime.Value.AddMinutes(15);
                dtpCheckOutTime.MaxDate = new DateTime(dtpCheckInDate.Value.Year, dtpCheckInDate.Value.Month, dtpCheckInDate.Value.Day, 23, 59, 59);
                dtpCheckOutTime.Value = dtpCheckInTime.Value.AddHours(1);
            }
            else
            {
                dtpCheckOutTime.MinDate = DateTimePicker.MinDateTime;
                dtpCheckOutTime.MaxDate = DateTimePicker.MaxDateTime;

                dtpCheckOutTime.MinDate = new DateTime(dtpCheckOutDate.Value.Year, dtpCheckOutDate.Value.Month, dtpCheckOutDate.Value.Day, 0, 0, 0);
                dtpCheckOutTime.MaxDate = new DateTime(dtpCheckOutDate.Value.Year, dtpCheckOutDate.Value.Month, dtpCheckOutDate.Value.Day, 23, 59, 59);
                dtpCheckOutTime.Value = new DateTime(dtpCheckOutDate.Value.Year, dtpCheckOutDate.Value.Month, dtpCheckOutDate.Value.Day, 8, 0, 0);
            }

            _isDateTimeChanging = false;
        }

        private void btnAddBooking_Click(object sender, EventArgs e)
        {
            if (selectedCustomer == null)
            {
                MessageBox.Show("Please select a customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (selectedPet == null)
            {
                MessageBox.Show("Please select a pet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            selectedService = (Service)cmbService.SelectedItem;

            if (selectedService == null)
            {
                MessageBox.Show("Please select a service.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateOnly checkInDate = DateOnly.FromDateTime(dtpCheckInDate.Value);
            TimeOnly checkInTime = TimeOnly.FromDateTime(dtpCheckInTime.Value);
            DateOnly checkOutDate = DateOnly.FromDateTime(dtpCheckOutDate.Value);
            TimeOnly checkOutTime = TimeOnly.FromDateTime(dtpCheckOutTime.Value);

            BookingManager.AddBooking(checkInDate, checkInTime, checkOutDate, checkOutTime, selectedService, selectedCustomer, selectedPet);
        }
    }
}
