using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoggyDaycare.Data.Attributes;

namespace DoggyDaycare.Models
{
    internal class Service
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

        private void SetName(string name)
        {
            if (name.Length == 0)
            {
                
            }

            Name = name;
        }

        private void SetStatus(string status)
        {
            Status = status;
        }

        private void SetBreedType(string breedType)
        {   
            BreedType = breedType;
        }

        private void SetPricePerHour(float pricePerHour)
        {
            if (pricePerHour == 0)
            {
                
            }

            PricePerHour = pricePerHour;
        }

        private void SetMaxCapacityPerSlot(int maxCapacityPerSlot)
        {
            if (maxCapacityPerSlot == 0)
            {

            }
            
            MaxCapacityPerSlot = maxCapacityPerSlot;
        }

        public string ToString()
        {
            return $"Service ID: {Id}\nService Name: {Name}\nBreed Type: {BreedType}\nPrice Per Hour: {PricePerHour}\nMax Capacity Per Time Slot: {MaxCapacityPerSlot}";
        }
    }
}
