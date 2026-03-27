using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoggyDaycare.Models
{
    internal class Service
    {
        int _id;
        string _status;
        string _name;
        string _breedType;
        int _pricePerHour;
        int _maxCapacityPerTimeSlot;

        public required int Id { get; init; }
        public required string Status { get; set; }
        public required string Name { get; set; }
        public required string BreedType { get; set; }
        public required int PricePerHour { get; set; }
        public required int MaxCapacityPerTimeSlot { get; set; }

        public Service(int id, 
                        string status, 
                        string name, 
                        string breedType, 
                        int pricePerHour, 
                        int maxCapacityPerTimeSlot)
        {
            Id = id;
            Status = status;
            Name = name;
            BreedType = breedType;
            PricePerHour = pricePerHour;
            MaxCapacityPerTimeSlot = maxCapacityPerTimeSlot;
        }

        public string ToString()
        {
            return $"Service ID: {Id}, Name: {Name}, Breed Type: {BreedType}, Price Per Hour: {PricePerHour}, Max Capacity Per Time Slot: {MaxCapacityPerTimeSlot}";
        }
    }
}
