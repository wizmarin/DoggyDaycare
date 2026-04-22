using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoggyDaycare.Data.Attributes;

namespace DoggyDaycare.Models
{
    public class Service
    {
        [ColumnName("SERVICE_ID")]
        public int Id { get; private set; }
        [ColumnName("STATUS")]
        public string Status { get; private set; }
        [ColumnName("NAME")]
        public string Name { get; set; }
        [ColumnName("BREED_TYPE")]
        public string BreedType { get; set; }
        [ColumnName("PRICE_PER_HOUR")]
        public float PricePerHour { get; set; }
        [ColumnName("MAX_CAPACITY_PER_SLOT")]
        public int MaxCapacityPerSlot { get; set; }

        public Service() { }

        public Service(string name, 
                        string breedType, 
                        float pricePerHour, 
                        int maxCapacityPerSlot)
        {
            Status = "Active";
            Name = name;
            BreedType = breedType;
            PricePerHour = pricePerHour;
            MaxCapacityPerSlot = maxCapacityPerSlot;
        }

        public Service(int id, 
                        string status, 
                        string name, 
                        string breedType, 
                        float pricePerHour, 
                        int maxCapacityPerSlot)
        {
            Id = id;
            Status = status;
            Name = name;
            BreedType = breedType;
            PricePerHour = pricePerHour;
            MaxCapacityPerSlot = maxCapacityPerSlot;
        }

        public string ToString()
        {
            return $"Service ID: {Id}\nService Name: {Name}\nBreed Type: {BreedType}\nPrice Per Hour: {PricePerHour}\nMax Capacity Per Time Slot: {MaxCapacityPerSlot}";
        }
    }
}
