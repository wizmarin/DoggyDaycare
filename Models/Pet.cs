using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoggyDaycare.Data.Attributes;
using DoggyDaycare.Managers;

namespace DoggyDaycare.Models
{
    public class Pet
    {
        [ColumnName("PET_ID")]
        public int Id { get; private set; }
        [ColumnName("STATUS")]
        public string Status { get; private set; }
        [ColumnName("OWNER_ID")]
        public int OwnerId { get; set; }
        [ColumnName("NAME")]
        public string Name { get; set; }
        [ColumnName("BREED_TYPE")]
        public string BreedType { get; set; }
        [ColumnName("AGE")]
        public int Age { get; set; }
        [ColumnName("SEX")]
        public string Sex { get; set; }
        [ColumnName("VET_CHECK_UP")]
        public DateTime VetCheckUp { get; set; }
        [ColumnName("FEEDING_NOTES")]
        public string FeedingNotes { get; set; }
        [ColumnName("MEDICAL_CONDITIONS")]
        public string? MedicalConditions { get; set; }
        [ColumnName("SOCIALISATION_LEVEL")]
        public string SocialisationLevel { get; set; }
        [ColumnName("KNOWN_TRIGGERS")]
        public string? KnownTriggers { get; set; }
        [ColumnName("BEHAVIOURAL_NOTES")]
        public string? BehaviouralNotes { get; set; }
        [ColumnName("ADDITIONAL_NOTES")]
        public string? AdditionalNotes { get; set; }

        public Pet()
        {
        }

        public Pet(int ownerId,
                    string name,
                    string breedType,
                    int age,
                    string sex,
                    DateTime vetCheckUp,
                    string feedingNotes,
                    string? medicalConditions,
                    string socialisationLevel,
                    string? knownTriggers,
                    string? behaviouralNotes,
                    string? additionalNotes)
        {
            Status = "Active";
            OwnerId = ownerId;
            Name = name;
            BreedType = breedType;
            Age = age;
            Sex = sex;
            VetCheckUp = vetCheckUp;
            FeedingNotes = feedingNotes;
            MedicalConditions = medicalConditions;
            SocialisationLevel = socialisationLevel;
            KnownTriggers = knownTriggers;
            BehaviouralNotes = behaviouralNotes;
            AdditionalNotes = additionalNotes;
        }

        public Pet(int id,
                    string status,
                    int ownerId,
                    string name,
                    string breedType,
                    int age,
                    string sex,
                    DateTime vetCheckUp,
                    string feedingNotes,
                    string? medicalConditions,
                    string socialisationLevel,
                    string? knownTriggers,
                    string? behaviouralNotes,
                    string? additionalNotes)
        {
            Id = id;
            Status = status;
            OwnerId = ownerId;
            Name = name;
            BreedType = breedType;
            Age = age;
            Sex = sex;
            VetCheckUp = vetCheckUp;
            FeedingNotes = feedingNotes;
            MedicalConditions = medicalConditions;
            SocialisationLevel = socialisationLevel;
            KnownTriggers = knownTriggers;
            BehaviouralNotes = behaviouralNotes;
            AdditionalNotes = additionalNotes;
        }

        public string ToString()
        {
            return $"Pet ID: {Id}\nOwner: {OwnerDisplay(OwnerId)}\nName: {Name}\nBreed: {BreedType}\nAge: {Age}\nSex {Sex}\nVet Check-Up: {VetCheckUp.ToShortDateString()}\nFeeding Notes: {FeedingNotes}\nMedical Conditions: {MedicalConditions}\nSocialisation Level: {SocialisationLevel}\nKnown Triggers: {KnownTriggers}\nBehavioural Notes: {BehaviouralNotes}\nAdditional Notes: {AdditionalNotes}";
        }

        internal string OwnerDisplay(int ownerId)
        {
            Customer owner = CustomerManager.GetCustomerById(ownerId);
            return owner.Display;
        }
    }
}
