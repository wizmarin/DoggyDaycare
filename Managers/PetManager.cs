using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
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

        internal static void RegisterPet(Customer owner, string name, string breedType,int age, string sex, DateTime vetCheckUp, string feedingNotes, string medicalConditions, string socialisationLevel, string knownTriggers, string behaviouralNotes, string additionalNotes)
        {
            string message = IsValidInput(name, age, vetCheckUp, feedingNotes, medicalConditions, knownTriggers, behaviouralNotes, additionalNotes); ;

            if (message != "valid") 
            {
                MessageBox.Show(message, "Input Not Valid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Pet pet = new Pet (owner.Id, name, breedType, age, sex, vetCheckUp, feedingNotes, medicalConditions,
                socialisationLevel, knownTriggers, behaviouralNotes, additionalNotes);

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

        internal static void UpdatePet(Pet pet, Customer owner, string name, string breedType, int age, string sex, DateTime vetCheckUp, string feedingNotes, string medicalConditions, string socialisationLevel, string knownTriggers, string behaviouralNotes, string additionalNotes)
        {
            string message = IsValidInput(name, age, vetCheckUp, feedingNotes, medicalConditions, knownTriggers, behaviouralNotes, additionalNotes);

            if (message != "valid")
            {
                MessageBox.Show(message, "Input Not Valid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            message = $"You are about to update the pet:\n\n{pet.ToString()}\n\nWith the following details:\n\n";

            if (pet.OwnerId != owner.Id)
            {
                message += $"Owner: {owner.Display}\n";
            }

            if (pet.Name != name)
            {
                message += $"Name: {name}\n";
            }

            if (pet.BreedType != breedType)
            {
                message += $"{breedType}\n";
            }

            if (pet.Age != age)
            {
                message += $"Age: {age}\n";
            }

            if (pet.Sex != sex)
            {
                message += $"Sex: {sex}\n";
            }

            if (pet.VetCheckUp != vetCheckUp)
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
                pet.OwnerId = owner.Id;
                pet.Name = name;
                pet.BreedType = breedType;
                pet.Age = age;
                pet.Sex = sex;
                pet.VetCheckUp = vetCheckUp;
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

        internal static void DeactivatePets()
        {

        }

        private static string IsValidInput(string name, int age, DateTime vetCheckUp, string feedingNotes, string medicalConditions, string knownTriggers, string behaviouralNotes, string additionalNotes)
        {
            string nameValidation = IsValidName(name);
            string ageValidation = IsValidAge(age);
            string vetCheckUpValidation = IsValidVetCheckUp(vetCheckUp, age);
            string feedingNotesValidation = IsValidFeedingNotes(feedingNotes);
            string medicalConditionsValidation = IsValidMedicalConditions(medicalConditions);
            string knownTriggersValidation = IsValidKnownTriggers(knownTriggers);
            string behaviouralNotesValidation = IsValidBehaviouralNotes(behaviouralNotes);
            string additionalNotesValidation = IsValidAdditionalNotes(additionalNotes);

            if (nameValidation == "valid" &&
                ageValidation == "valid" &&
                vetCheckUpValidation == "valid" &&
                feedingNotesValidation == "valid" &&
                medicalConditionsValidation == "valid" &&
                knownTriggersValidation == "valid" &&
                behaviouralNotesValidation == "valid" &&
                additionalNotesValidation == "valid")
            {
                return "valid";
            }

            string errorMessage = "Please correct the following errors:\n\n";

            if (nameValidation != "valid")
            {
                errorMessage += "Name: " + nameValidation + "\n";
            }

            if (ageValidation != "valid")
            {
                errorMessage += "Age: " + ageValidation + "\n";
            }

            if (vetCheckUpValidation != "valid")
            {
                errorMessage += "Vet Check Up: " + vetCheckUpValidation + "\n";
            }

            if (feedingNotesValidation != "valid")
            {
                errorMessage += "Feeding Notes: " + feedingNotesValidation + "\n";
            }

            if (medicalConditionsValidation != "valid")
            {
                errorMessage += "Medical Conditions: " + medicalConditionsValidation + "\n";
            }

            if (knownTriggersValidation != "valid")
            {
                errorMessage += "Known Triggers: " + knownTriggersValidation + "\n";
            }

            if (behaviouralNotesValidation != "valid")
            {
                errorMessage += "Behavioural Notes: " + behaviouralNotesValidation + "\n";
            }

            if (additionalNotesValidation != "valid")
            {
                errorMessage += "Additional Notes: " + additionalNotesValidation + "\n";
            }

            return errorMessage;
        }

        private static string IsValidName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return "Full name cannot be empty.";
            }

            if (name.StartsWith(" ") || name.EndsWith(" "))
            {
                return "Full name cannot start or end with a space.";
            }

            foreach (char c in name)
            {
                if (!char.IsLetter(c))
                {
                    return "Full name can only contain letters and space.";
                }
            }

            return "valid";
        }

        private static string IsValidAge(int age)
        {
            if (age == 0)
            {
                return "Age must be a positive number.";
            }

            return "valid";
        }

        private static string IsValidVetCheckUp(DateTime vetCheckUp, int age)
        {
            DateTime today = DateTime.Today;
            DateTime birthday = today.AddYears(-age).AddYears(-1);

            if (birthday > vetCheckUp)
            {
                return "Vet check-up date cannot be before the pet's birthdate.";
            }

            if (today < vetCheckUp)
            {
                return "Vet check-up date cannot be in the future.";
            }

            return "valid";
        }

        private static string IsValidFeedingNotes(string feedingNotes)
        {
            if (string.IsNullOrWhiteSpace(feedingNotes))
            {
                return "Feeding notes cannot be empty.";
            }

            if (feedingNotes.StartsWith(" ") || feedingNotes.EndsWith(" "))
            {
                return "Medical conditions cannot start or end with a space.";
            }

            return "valid";
        }

        private static string IsValidMedicalConditions(string medicalConditions)
        {
            if (string.IsNullOrEmpty(medicalConditions))
            {
                return "valid";
            }

            if (medicalConditions.All(c => c == ' '))
            {
                return "Medical conditions cannot contain only spaces.";
            }

            if (medicalConditions.StartsWith(" ") || medicalConditions.EndsWith(" "))
            {
                return "Medical conditions cannot start or end with a space.";
            }

            return "valid";
        }

        private static string IsValidKnownTriggers(string knownTriggers)
        {
            if (string.IsNullOrEmpty(knownTriggers))
            {
                return "valid";
            }

            if (knownTriggers.All(c => c == ' '))
            {
                return "Known triggers cannot contain only spaces.";
            }

            if (knownTriggers.StartsWith(" ") || knownTriggers.EndsWith(" "))
            {
                return "Known triggers cannot start or end with a space.";
            }

            return "valid";
        }

        private static string IsValidBehaviouralNotes(string behaviouralNotes)
        {
            if (string.IsNullOrEmpty(behaviouralNotes))
            {
                return "valid";
            }

            if (behaviouralNotes.All(c => c == ' '))
            {
                return "Behavioural notes cannot contain only spaces.";
            }

            if (behaviouralNotes.StartsWith(" ") || behaviouralNotes.EndsWith(" "))
            {
                return "Behavioural notes cannot start or end with a space.";
            }

            return "valid";
        }

        private static string IsValidAdditionalNotes(string additionalNotes)
        {
            if (string.IsNullOrEmpty(additionalNotes))
            {
                return "valid";
            }

            if (additionalNotes.All(c => c == ' '))
            {
                return "Additional notes cannot contain only spaces.";
            }

            if (additionalNotes.StartsWith(" ") || additionalNotes.EndsWith(" "))
            {
                return "Additional notes cannot start or end with a space.";
            }

            return "valid";
        }

    }
}