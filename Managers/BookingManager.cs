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
    internal static class BookingManager
    {
        internal static List<Booking> GetAllBookings()
        {
            DataSet ds = BookingRepo.GetAll();
            List<Booking> bookings = DataSetMapper.MapToList<Booking>(ds);
            return bookings;
        }

        internal static Booking GetBookingById(int id)
        {
            OracleDataReader reader = BookingRepo.GetById(id);
            Booking booking = OracleDataReaderMapper.MapToObject<Booking>(reader);
            return booking;
        }

        internal static List<Booking> GetActiveBookingsByCustomerId(int customerId)
        {
            DataSet ds = BookingRepo.GetActiveByCustomerId(customerId);
            List<Booking> bookings = DataSetMapper.MapToList<Booking>(ds);
            return bookings;
        }

        internal static List<Booking> GetActiveBookingsByPetId(int petId)
        {
            DataSet ds = BookingRepo.GetActiveByPetId(petId);
            List<Booking> bookings = DataSetMapper.MapToList<Booking>(ds);
            return bookings;
        }

        internal static List<Booking> GetActiveBookingsByServiceId(int serviceId)
        {
            DataSet ds = BookingRepo.GetActiveByServiceId(serviceId);
            List<Booking> bookings = DataSetMapper.MapToList<Booking>(ds);
            return bookings;
        }

        internal static void LoadUpdateForm(Booking booking)
        {
            if (booking == null)
            {
                throw new NoSelectionException("No booking selected. Please select a booking to update.");
            }

            var mainForm = Application.OpenForms.OfType<frmMain>().FirstOrDefault();
            var loadOption = "Hide";

            mainForm.OpenChildForm(new frmUpdateBooking(), loadOption);
        }

        internal static void AddBooking(DateOnly checkInDate, TimeOnly checkInTime, DateOnly checkOutDate,
                                        TimeOnly checkOutTime, Service service, Customer customer, Pet pet)
        {
            DateTime checkIn = new DateTime(checkInDate.Year, checkInDate.Month, checkInDate.Day, checkInTime.Hour, checkInTime.Minute, 0);
            DateTime checkOut = new DateTime(checkOutDate.Year, checkOutDate.Month, checkOutDate.Day, checkOutTime.Hour, checkOutTime.Minute, 0);

            string message = IsValidInput(checkIn, checkOut, service);

            if (message != "valid")
            {
                MessageBox.Show(message, "Input Not Valid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            TimeSpan duration = checkOut - checkIn;
            float pricePerHour = service.PricePerHour;
            float actualPrice;

            if (duration.TotalHours < 1)
            {
                actualPrice = pricePerHour;
            }
            else
            {
                actualPrice = pricePerHour * (float)duration.TotalHours;
            }

            Booking booking = new Booking(service.Id, pricePerHour, checkIn, checkOut, customer.Id, pet.Id, actualPrice);

            message = $"You are about to create the following booking:\n\n{booking.ToString()}\n\nWould you like to proceed?";

            DialogResult result = MessageBox.Show(message, "Confirm Registration", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            var mainForm = Application.OpenForms.OfType<frmMain>().FirstOrDefault();
            var loadOption = "Close";

            if (result == DialogResult.Cancel)
            {
                mainForm.OpenChildForm(new frmBookings(), loadOption);
            }

            if (result == DialogResult.No)
            {
                return;
            }

            BookingRepo.Insert(booking);
            MessageBox.Show("Booking has been registered successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            mainForm.OpenChildForm(new frmBookings(), loadOption);
        }

        internal static void UpdateBooking(Booking booking, DateOnly checkInDate, TimeOnly checkInTime, DateOnly checkOutDate,
                                        TimeOnly checkOutTime, float pricePerHour, float actualPrice,
                                        Service service, Customer customer, Pet pet)
        {
            // TODO: Implement update logic with validation and confirmation message box, similar to AddBooking method.
        }

        internal static void CheckInBooking(Booking booking)
        {
            // TODO: Implement check-in logic, including validation to ensure the booking is eligible for check-in (e.g., current date and time is within a certain range of the booking's check-in time).
        }

        internal static void CheckOutBooking(Booking booking)
        {
            // TODO: Implement check-out logic, including validation to ensure the booking is eligible for check-out (e.g., current date and time is within a certain range of the booking's check-out time).
        }

        internal static void CancelBooking(Booking booking)
        {
            if (booking == null)
            {
                throw new NoSelectionException("No booking selected. Please select a booking to cancel.");
            }

            string message = $"You are about to deactivate the booking:\n\n{booking.ToString()}\n\nThis action cannot be undone.";

            DialogResult result = MessageBox.Show(message, "Confirm Deactivation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.Cancel)
            {
                throw new DeactivationAbortedException("Booking cancelation proccess was aborted.");
            }

            BookingRepo.Deactivate(booking.Id);
            MessageBox.Show("Booking has been deactivated successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private static string IsValidInput(DateTime checkIn, DateTime checkOut, Service service)
        {
            string checkInValidation = IsValidCheckIn(checkIn);
            string checkOutValidation = IsValidCheckOut(checkIn, checkOut);

            string message = "Please correct the following errors:\n\n";

            if (service == null)
            {
                message += "Service: Service must be selected.\n";
                return message;
            }

            if (checkInValidation == "valid" && checkOutValidation == "valid")
            {
                string timeSlotValidation = IsValidTimeSlot(checkIn, checkOut, service);
                
                if (timeSlotValidation != "valid")
                {
                    return timeSlotValidation;
                }
            }

            if (checkInValidation != "valid")
            {
                message += $"Check-in: {checkInValidation}\n";
            }

            if (checkOutValidation != "valid")
            {
                message += $"Check-out: {checkOutValidation}\n";
            }

            return message;
        }

        private static string IsValidCheckIn(DateTime checkIn)
        {
            if (DateTime.Now > checkIn)
            {
                return "Check-in date and time cannot be in the past.";
            }

            return "valid";
        }

        private static string IsValidCheckOut(DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                return "Check-out date and time must be after check-in date and time.";
            }

            return "valid";
        }

        private static string IsValidTimeSlot(DateTime startDateTime, DateTime endDateTime, Service service)
        {
            DataSet ds = BookingRepo.GetActiveByDateRange(startDateTime, endDateTime, service.Id);
            List<Booking> bookings = DataSetMapper.MapToList<Booking>(ds);
            
            if (bookings == null || bookings.Count == 0)
            {
                return "valid";
            }

            List<DateTime> uniqueTimes = bookings.SelectMany(b => new[] { b.CheckIn, b.CheckOut }).Distinct().OrderBy(dt => dt).ToList();
            int count = uniqueTimes.Count;
            int[] overlaping = new int[count];

            foreach (var b in bookings)
            {
                int indexStart = uniqueTimes.BinarySearch(b.CheckIn);
                int indexEnd = uniqueTimes.BinarySearch(b.CheckOut);

                for (int i = indexStart; i < indexEnd; i++)
                {
                    overlaping[i] ++;
                }
            }

            string message = $"Time slot from {startDateTime} to {endDateTime} has the following overlapping bookings:\n\n";
            int overlapCount = 0;

            for (int i = 0; i < count; i++)
            {
                if (overlaping[i] >= service.MaxCapacityPerSlot)
                {
                    message += $"Overlapping booking at {uniqueTimes[i]} exceeds the maximum capacity of {service.MaxCapacityPerSlot}.\n";
                    overlapCount++;
                }
            }
            
            if (overlapCount > 0)
            {
                return message;
            }

            return "valid";
        }

    }
}
