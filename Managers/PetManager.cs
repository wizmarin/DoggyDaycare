using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoggyDaycare.Data.Mappers;
using DoggyDaycare.Data.Repositories;
using DoggyDaycare.Exceptions;
using DoggyDaycare.Forms;
using DoggyDaycare.Models;
using Oracle.ManagedDataAccess.Client;


namespace DoggyDaycare.Managers
{
    internal static class PetManager
    {
        internal static List<Pet> GetAllPets()
        {
            DataSet ds = PetRepo.GetAll();
            List<Pet> pets = DataSetMapper.MapToList<Pet>(ds);
            return pets;
        }

        internal static List<Pet> GetPetsByOwnerId(int ownerId)
        {
            OracleDataReader reader = PetRepo.GetByOwnerId(ownerId);
            List<Pet> pets = OracleDataReaderMapper.MapToList<Pet>(reader);
            return pets;
        }

        internal static void LoadUpdateForm(Pet pet)
        {
            if (pet == null)
            {
                throw new NoSelectionException("No pet selected. Please select a pet to update.");
            }
            else
            {
                var mainForm = Application.OpenForms.OfType<frmMain>().FirstOrDefault();
                var loadOption = "Hide";

                mainForm.OpenChildForm(new frmUpdatePet(pet), loadOption);
            }
        }

        internal static void RegisterPet(int ownerId, string name, int age, string sex, string vetCheckUp, string feedingNotes, string medicalConditions, string socialisationLevel, string knownTriggers, string behaviouralNotes, string additionalNotes)
        {
            // TODO: Implement validation for pet registration inputs and change message to result of validation
            string message = string.Empty;

            if (message != "valid") 
            {
                MessageBox.Show(message, "Input Not Valid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Pet pet = new Pet
            {
                OwnerId = ownerId,
                Name = name,
                Age = age,
                Sex = sex,
                VetCheckUp = DateTime.Parse(vetCheckUp),
                FeedingNotes = feedingNotes,
                MedicalConditions = medicalConditions,
                SocialisationLevel = socialisationLevel,
                KnownTriggers = knownTriggers,
                BehaviouralNotes = behaviouralNotes,
                AdditionalNotes = additionalNotes
            };

            message = $"You are about to register the following pet:\n\n{pet.ToString()}\n\nWould you like to proceed?";

            DialogResult result = MessageBox.Show(message, "Confirm Registration", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        
            var mainForm = Application.OpenForms.OfType<frmMain>().FirstOrDefault();
            var loadOption = "Close";

            if (result == DialogResult.Cancel)
            {
                mainForm.OpenChildForm(new frmPets(), loadOption);
            }
            else if (result == DialogResult.No) 
            {
                return;
            }
            else
            {
                PetRepo.Insert(pet);
                MessageBox.Show("Pet has been registered successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mainForm.OpenChildForm(new frmPets(), loadOption);
            }
        }

        internal static void UpdatePet(Pet pet, int ownerId, string name, int age, string sex, string vetCheckUp, string feedingNotes, string medicalConditions, string socialisationLevel, string knownTriggers, string behaviouralNotes, string additionalNotes)
        {
            string message = string.Empty;

            if (message != "valid")
            {
                MessageBox.Show(message, "Input Not Valid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            message = $"You are about to update the pet:\n\n{pet.ToString()}\n\nWith the following details:\n\n";

            if (pet.OwnerId != ownerId)
            {
                message += $"Owner ID: {ownerId}\n";
            }

            if (pet.Name != name)
            {
                message += $"Name: {name}\n";
            }

            if (pet.Age != age)
            {
                message += $"Age: {age}\n";
            }

            if (pet.Sex != sex)
            {
                message += $"Sex: {sex}\n";
            }

            if (pet.VetCheckUp != DateTime.Parse(vetCheckUp))
            {
                message += $"Vet Check-Up: {vetCheckUp}\n";
            }

            if (pet.FeedingNotes != feedingNotes)
            {
                message += $"Feeding Notes: {feedingNotes}\n";
            }

            if (pet.MedicalConditions != medicalConditions)
            {
                message += $"Medical Conditions: {medicalConditions}\n";
            }

            if (pet.SocialisationLevel != socialisationLevel)
            {
                message += $"Socialisation Level: {socialisationLevel}\n";
            }

            if (pet.KnownTriggers != knownTriggers)
            {
                message += $"Known Triggers: {knownTriggers}\n";
            }

            if (pet.BehaviouralNotes != behaviouralNotes)
            {
                message += $"Behavioural Notes: {behaviouralNotes}\n";
            }

            if (pet.AdditionalNotes != additionalNotes)
            {
                message += $"Additional Notes: {additionalNotes}\n";
            }

            message += "\nWould you like to proceed with the update?";

            DialogResult result = MessageBox.Show(message, "Confirm Update", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            var mainForm = Application.OpenForms.OfType<frmMain>().FirstOrDefault();
            var petsForm = Application.OpenForms.OfType<frmPets>().FirstOrDefault();
            var loadOption = "Close";

            if (result == DialogResult.Cancel)
            {
                mainForm.OpenChildForm(new frmPets(), loadOption);
                return;
            }
            else if (result == DialogResult.No)
            {
                return;
            }
            else
            {
                pet.OwnerId = ownerId;
                pet.Name = name;
                pet.Age = age;
                pet.Sex = sex;
                pet.VetCheckUp = DateTime.Parse(vetCheckUp);
                pet.FeedingNotes = feedingNotes;
                pet.MedicalConditions = medicalConditions;
                pet.SocialisationLevel = socialisationLevel;
                pet.KnownTriggers = knownTriggers;
                pet.BehaviouralNotes = behaviouralNotes;
                pet.AdditionalNotes = additionalNotes;

                PetRepo.Update(pet);

                MessageBox.Show("Pet has been updated successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                petsForm.UpdateDataSource(pet, "update");

                mainForm.OpenChildForm(petsForm, loadOption);
            }
        }

        internal static void DeactivatePet(Pet pet)
        {
            // TODO: Implement a check to see if there are any active or future bookings for this pet before deactivating it. If there are, throw an exception.

            if (pet == null)
            {
                throw new NoSelectionException("No pet selected. Please select a pet to deactivate.");
            }
            else
            {
                string message = $"You are about to deactivate the pet:\n\n{pet.ToString()}\n\nThis action cannot be undone.";
            
                DialogResult result = MessageBox.Show(message, "Confirm Deactivation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.Cancel)
                {
                    throw new DeactivationAbortedException();
                }
                else
                {
                    PetRepo.Deactivate(pet.Id);
                    MessageBox.Show("Pet has been deactivated successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private static string IsValidInput(Pet pet, int ownerId, string name, int age, string sex, string vetCheckUp, string feedingNotes, string medicalConditions, string socialisationLevel, string knownTriggers, string behaviouralNotes, string additionalNotes)
        {
            return "valid";
        }

        // TODO: Implement validation methods for each field, consider changing OwnerId to Owner object in methods.
    }
}