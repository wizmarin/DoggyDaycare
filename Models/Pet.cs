using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoggyDaycare.Models
{
    internal class Pet
    {
        private int _id;
        private string _status;
        private int _ownerId;
        private string _name;
        private string _breedType;
        private int _age;
        private string _sex;
        private DateTime _vetCheckUp;
        private string _feedingNotes;
        private string? _medicalConditions;
        private string _socializationLevel;
        private string? _knownTriggers;
        private string? _behavioralNotes;
        private string? _additionalNotes;

        public required int Id { get; init; }
        public required string Status { get; set; }
        public required int OwnerId { get; set; }
        public required string Name { get; set; }
        public required string BreedType { get; set; }
        public required int Age { get; set; }
        public required string Sex { get; set; }
        public required DateTime VetCheckUp { get; set; }
        public required string FeedingNotes { get; set; }
        public string? MedicalConditions { get; set; }
        public required string SocializationLevel { get; set; }
        public string? KnownTriggers { get; set; }
        public string? BehavioralNotes { get; set; }
        public string? AdditionalNotes { get; set; }

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
                    string socializationLevel,
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
            SocializationLevel = socializationLevel;
            KnownTriggers = knownTriggers;
            BehavioralNotes = behaviouralNotes;
            AdditionalNotes = additionalNotes;
        }

        public string ToString()
        {
            return $"Pet ID: {Id}, Name: {Name}, Breed: {BreedType}, Age: {Age}, Sex {Sex}, Vet Check-Up: {VetCheckUp.ToShortDateString()}, Feeding Notes: {FeedingNotes}, Medical Conditions: {MedicalConditions}, Socialization Level: {SocializationLevel}, Known Triggers: {KnownTriggers}, Behavioral Notes: {BehavioralNotes}, Additional Notes: {AdditionalNotes}";
        }
    }
}
