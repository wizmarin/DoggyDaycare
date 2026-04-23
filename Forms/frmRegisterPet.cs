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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DoggyDaycare.Forms
{
    public partial class frmRegisterPet : Form
    {
        private List<Customer> customers;
        private bool _isSearching = false;

        public frmRegisterPet()
        {
            InitializeComponent();
        }

        private void frmRegisterPet_Load(object sender, EventArgs e)
        {
            customers = CustomerManager.GetAllCustomers();

            cmbOwner.DisplayMember = "Display";
            cmbOwner.ValueMember = "Id";
            cmbOwner.DataSource = customers;

            cmbBreedType.Text = "Medium";
            cmbSex.Text = "Male";
            dtpVetCheckUp.Value = DateTime.Today;
            cmbSocialisationLevel.Text = "Unknown";
        }

        private void cmbOwner_TextChanged(object sender, EventArgs e)
        {
            if (_isSearching) return;

            _isSearching = true;

            string keyword = cmbOwner.Text;

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

            cmbOwner.DataSource = new List<Customer>(filtered);
            cmbOwner.DisplayMember = "Display";
            cmbOwner.ValueMember = "Id";

            cmbOwner.Text = keyword;
            cmbOwner.Select(keyword.Length, 0);

            if (filtered.Count > 0)
                cmbOwner.DroppedDown = true;

            _isSearching = false;
        }

        private void btnRegisterPet_Click(object sender, EventArgs e)
        {
            if (cmbOwner.SelectedItem == null)
            {
                MessageBox.Show("Please select customer from the list as pet owner.", "Owner not Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Customer owner = (Customer)cmbOwner.SelectedItem;
            string name = txtName.Text;
            string breedType = cmbBreedType.Text;
            int age = (int)nudAge.Value;
            string sex = cmbSex.Text;
            DateTime vetCheckUp = dtpVetCheckUp.Value.Date;
            string feedingNotes = txtFeedingNotes.Text;
            string medicalConditions = txtMedicalConditions.Text;
            string socialisationLevel = cmbSocialisationLevel.Text;
            string knownTriggers = txtKnownTriggers.Text;
            string behaviouralNotes = txtBehaviouralNotes.Text;
            string additionalNotes = txtAdditionalNotes.Text;

            PetManager.RegisterPet(owner, name, breedType, age, sex, vetCheckUp, feedingNotes, medicalConditions, socialisationLevel, knownTriggers, behaviouralNotes, additionalNotes);
        }
    }
}
