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
    public partial class frmPets : Form
    {
        private UserSessionManager session = UserSessionManager.GetInstance();
        private bool _isDataLoading = false;
        private Pet selected;
        private List<Pet> dataSource;

        public frmPets()
        {
            InitializeComponent();
        }

        private void frmPets_Load(object sender, EventArgs e)
        {
            _isDataLoading = true;

            if (session.GetCurrentUser() != "admin")
            {
                btnDeactivate.Enabled = false;
            }

            LoadAllPets();
            _isDataLoading = false;
        }

        private void dgvResult_SelectionChanged(object sender, EventArgs e)
        {
            if (_isDataLoading) return;

            if (dgvResult.SelectedRows.Count == 0)
            {
                ClearLabels();
                selected = new Pet();
                return;
            }

            selected = (Pet)dgvResult.SelectedRows[0].DataBoundItem;

            lblPetID.Text = $"Pet ID: {selected.Id}";
            lblOwner.Text = $"Owner: {selected.OwnerId}";
            lblPetName.Text = $"Pet Name: {selected.Name}";
            lblBreedType.Text = $"Breed Type: {selected.BreedType}";
            lblAge.Text = $"Age: {selected.Age}";
            lblSex.Text = $"Sex: {selected.Sex}";
            lblFeedingNotes.Text = $"Feeding Notes: {selected.FeedingNotes}";
            lblVetCheckUp.Text = $"Vet Check-Up: {selected.VetCheckUp.ToShortDateString()}";
            lblMedicalConditions.Text = $"Medical Conditions: {selected.MedicalConditions}";
            lblSocialisationLevel.Text = $"Socialisation Level: {selected.SocialisationLevel}";
            lblKnownTriggers.Text = $"Known Triggers: {selected.KnownTriggers}";
            lblBehaviouralNotes.Text = $"Behavioural Notes: {selected.BehaviouralNotes}";
            lblAdditionalNotes.Text = $"Additional Notes: {selected.AdditionalNotes}";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // TODO: Implement search functionality based on user input
        }

        private void btnUpdateInformation_Click(object sender, EventArgs e)
        {
            try
            {
                PetManager.LoadUpdateForm(selected);
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
                PetManager.DeactivatePet(selected);
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

        private void LoadAllPets()
        {
            dataSource = PetManager.GetAllPets();
            dgvResult.DataSource = dataSource;
            FormatDataView();
        }

        internal void UpdateDataSource(Pet pet, string option)
        {
            if (option == "update")
            {
                int index = dataSource.FindIndex(p => p.Id == pet.Id);
                if (index != -1)
                {
                    dataSource[index] = pet;
                }
            }
            else if (option == "deactivate")
            {
                dataSource.RemoveAll(p => p.Id == pet.Id);
            }

            dgvResult.DataSource = null;
            dgvResult.DataSource = dataSource;
            FormatDataView();
        }

        private void FormatDataView()
        {
            dgvResult.Columns["Status"].Visible = false;
            dgvResult.Columns["OwnerId"].Visible = false;
            dgvResult.Columns["MedicalConditions"].Visible = false;
            dgvResult.Columns["KnownTriggers"].Visible = false;
            dgvResult.Columns["BehaviouralNotes"].Visible = false;
            dgvResult.Columns["AdditionalNotes"].Visible = false;

            dgvResult.Columns["Id"].HeaderText = "ID";
            dgvResult.Columns["Name"].HeaderText = "Pet Name";
            dgvResult.Columns["BreedType"].HeaderText = "Breed Type";
            dgvResult.Columns["VetCheckUp"].HeaderText = "Vet Check Up";
            dgvResult.Columns["FeedingNotes"].HeaderText = "Feeding Notes";
            dgvResult.Columns["SocialisationLevel"].HeaderText = "Social. Level";

            dgvResult.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvResult.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvResult.Columns["BreedType"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dgvResult.Columns["Age"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dgvResult.Columns["Sex"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvResult.Columns["VetCheckUp"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dgvResult.Columns["FeedingNotes"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvResult.Columns["SocialisationLevel"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void ClearLabels()
        {
            lblPetID.Text = $"Pet ID: ";
            lblOwner.Text = $"Owner: ";
            lblPetName.Text = $"Pet Name: ";
            lblBreedType.Text = $"Breed Type: ";
            lblAge.Text = $"Age: ";
            lblSex.Text = $"Sex: ";
            lblFeedingNotes.Text = $"Feeding Notes: ";
            lblVetCheckUp.Text = $"Vet Check-Up: ";
            lblMedicalConditions.Text = $"Medical Conditions: ";
            lblSocialisationLevel.Text = $"Socialisation Level: ";
            lblKnownTriggers.Text = $"Known Triggers: ";
            lblBehaviouralNotes.Text = $"Behavioural Notes: ";
            lblAdditionalNotes.Text = $"Additional Notes: ";
        }
    }
}
