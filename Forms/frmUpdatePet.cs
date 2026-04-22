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

namespace DoggyDaycare.Forms
{
    public partial class frmUpdatePet : Form
    {
        private Pet pet;

        public frmUpdatePet(Pet pet)
        {
            InitializeComponent();
            this.pet = pet;
        }

        private void frmUpdatePet_Load(object sender, EventArgs e)
        {
            cmbOwner.Text = pet.OwnerId.ToString();
            txtName.Text = pet.Name;
            cmbBreedType.Text = pet.BreedType;
            nudAge.Value = pet.Age;
            cmbSex.Text = pet.Sex;
            txtFeedingNotes.Text = pet.FeedingNotes;
            dtpVetCheckUp.Value = pet.VetCheckUp;
            txtMedicalConditions.Text = pet.MedicalConditions;
            cmbSocialisationLevel.Text = pet.SocialisationLevel;
            txtKnownTriggers.Text = pet.KnownTriggers;
            txtBehaviouralNotes.Text = pet.BehaviouralNotes;
            txtAdditionalNotes.Text = pet.AdditionalNotes;
        }
    }
}
