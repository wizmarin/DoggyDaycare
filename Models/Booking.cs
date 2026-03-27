using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoggyDaycare.Models
{
    internal class Booking
    {
        private int _id;
        private string _status;
        private int _serviceId;
        private int _pricePerHour;
        private DateTime _checkInDate;
        private DateTime _checkInTime;
        private DateTime _checkOutDate;
        private DateTime _checkOutTime;
        private int _customerId;
        private int _petId;
        private int _actualPrice;

        public int Id { get; init; }
        public required string Status { get; set; }
        public int ServiceId { get; set; }
        public int PricePerHour { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckInTime { get; set; }
        public DateTime CheckOutDate { get; set; }
        public DateTime CheckOutTime { get; set; }
        public int CustomerId { get; set; }
        public int PetId { get; set; }
        public int ActualPrice { get; set; }

        public Booking(int id, 
                        string status, 
                        int serviceId, 
                        int pricePerHour, 
                        DateTime checkInDate, 
                        DateTime checkInTime, 
                        DateTime checkOutDate, 
                        DateTime checkOutTime, 
                        int customerId, 
                        int petId, 
                        int actualPrice)
        {
            Id = id;
            Status = status;
            ServiceId = serviceId;
            PricePerHour = pricePerHour;
            CheckInDate = checkInDate;
            CheckInTime = checkInTime;
            CheckOutDate = checkOutDate;
            CheckOutTime = checkOutTime;
            CustomerId = customerId;
            PetId = petId;
            ActualPrice = actualPrice;
        }

        public string ToString()
        {
            return $"Booking ID: {Id}, Status: {Status}, Service ID: {ServiceId}, Price Per Hour: {PricePerHour}, Check-In: {CheckInDate.ToShortDateString()} {CheckInTime.ToShortTimeString()}, Check-Out: {CheckOutDate.ToShortDateString()} {CheckOutTime.ToShortTimeString()}, Customer ID: {CustomerId}, Pet ID: {PetId}, Actual Price: {ActualPrice}";
        }
    }
}
