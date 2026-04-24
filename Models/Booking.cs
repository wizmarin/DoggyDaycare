using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoggyDaycare.Data.Attributes;
using DoggyDaycare.Managers;

namespace DoggyDaycare.Models
{
    public class Booking
    {
        [ColumnName("BOOKING_ID")]
        public int Id { get; private set; }
        [ColumnName("STATUS")]
        public string Status { get; set; }
        [ColumnName("SERVICE_ID")]
        public int ServiceId { get; set; }
        [ColumnName("PRICE_PER_HOUR")]
        public float PricePerHour { get; set; }
        [ColumnName("CHECK_IN")]
        public DateTime CheckIn { get; set; }
        [ColumnName("CHECK_OUT")]
        public DateTime CheckOut { get; set; }
        [ColumnName("CUSTOMER_ID")]
        public int CustomerId { get; set; }
        [ColumnName("PET_ID")]
        public int PetId { get; set; }
        [ColumnName("ACTUAL_PRICE")]
        public float ActualPrice { get; set; }

        public DateOnly CheckInDate { get; set; }
        public TimeOnly CheckInTime { get; set; }
        public DateOnly CheckOutDate { get; set; }
        public TimeOnly CheckOutTime { get; set; }

        public Booking() { }

        public Booking(int serviceId,
                        float pricePerHour,
                        DateTime checkIn,
                        DateTime checkOut,
                        int customerId,
                        int petId,
                        float actualPrice)
        {
            Status = "Active";
            ServiceId = serviceId;
            PricePerHour = pricePerHour;
            CheckIn = checkIn;
            CheckInDate = DateOnly.FromDateTime(CheckIn);
            CheckInTime = TimeOnly.FromDateTime(CheckIn);
            CheckOut = checkOut;
            CheckOutDate = DateOnly.FromDateTime(CheckOut);
            CheckOutTime = TimeOnly.FromDateTime(CheckOut);
            CustomerId = customerId;
            PetId = petId;
            ActualPrice = actualPrice;
        }

        public Booking(int id, 
                        string status, 
                        int serviceId, 
                        float pricePerHour,
                        DateTime checkIn,
                        DateTime checkOut, 
                        int customerId, 
                        int petId, 
                        float actualPrice)
        {
            Id = id;
            Status = status;
            ServiceId = serviceId;
            PricePerHour = pricePerHour;
            CheckIn = checkIn;
            CheckInDate = DateOnly.FromDateTime(CheckIn);
            CheckInTime = TimeOnly.FromDateTime(CheckIn);
            CheckOut = checkOut;
            CheckOutDate = DateOnly.FromDateTime(CheckOut);
            CheckOutTime = TimeOnly.FromDateTime(CheckOut);
            CustomerId = customerId;
            PetId = petId;
            ActualPrice = actualPrice;
        }

        public string ToString()
        {
            return $"Booking ID: {Id}\nStatus: {Status}\nService: {ServiceDisplay(ServiceId)}\nPrice Per Hour: {PricePerHour}\nCheck-In: {CheckInDate.ToShortDateString()} {CheckInTime.ToShortTimeString()}\nCheck-Out: {CheckOutDate.ToShortDateString()} {CheckOutTime.ToShortTimeString()}\nCustomer: {CustomerDisplay(CustomerId)}\nPet: {PetDisplay(PetId)}\nActual Price: {ActualPrice}";
        }

        internal string ServiceDisplay(int serviceId)
        {
            Service service = ServiceManager.GetServiceById(serviceId);
            return service.Display;
        }

        internal string CustomerDisplay(int customerId)
        {
            Customer customer = CustomerManager.GetCustomerById(customerId);
            return customer.Display;
        }

        internal string PetDisplay(int petId)
        {
            Pet pet = PetManager.GetPetById(petId);
            return pet.Name;
        }
    }
}
