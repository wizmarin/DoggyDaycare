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
        public int Id { get; set; }
        [ColumnName("STATUS")]
        public string Status { get; set; }
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
                        int pricePerHour, 
                        int maxCapacityPerSlot)
        {
            SetStatus("Active");
            SetName(name);
            SetBreedType(breedType);
            SetPricePerHour(pricePerHour);
            SetMaxCapacityPerSlot(maxCapacityPerSlot);
        }

        public Service(int id, 
                        string status, 
                        string name, 
                        string breedType, 
                        int pricePerHour, 
                        int maxCapacityPerSlot)
        {
            SetId(id);
            SetStatus(status);
            SetName(name);
            SetBreedType(breedType);
            SetPricePerHour(pricePerHour);
            SetMaxCapacityPerSlot(maxCapacityPerSlot);
        }

        private void SetId(int id)
        {
            Id = id;
        }

        internal void SetName(string name)
        {
            Name = name;
        }

        private void SetStatus(string status)
        {
            Status = status;
        }

        internal void SetBreedType(string breedType)
        {   
            BreedType = breedType;
        }

        internal void SetPricePerHour(float pricePerHour)
        {
            PricePerHour = pricePerHour;
        }

        internal void SetMaxCapacityPerSlot(int maxCapacityPerSlot)
        {
            MaxCapacityPerSlot = maxCapacityPerSlot;
        }

        public string ToString()
        {
            return $"Service ID: {Id}\nService Name: {Name}\nBreed Type: {BreedType}\nPrice Per Hour: {PricePerHour}\nMax Capacity Per Time Slot: {MaxCapacityPerSlot}";
        }
    }
}
