using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoggyDaycare.Data.Database;
using DoggyDaycare.Models;
using Oracle.ManagedDataAccess.Client;

namespace DoggyDaycare.Data.Repositories
{
    internal static class BookingRepo
    {
        private static DatabaseConnection _db = DatabaseConnection.GetInstance();

        internal static DataSet GetAll()
        {
            string query = $@"
                SELECT * 
                FROM Bookings 
                WHERE Status != 'Cancelled'";

            DataSet ds = _db.ExecuteMultiRowQuery(query);
            return ds;
        }

        internal static OracleDataReader GetById(int id)
        {
            string query = $@"
                SELECT * 
                FROM Bookings 
                WHERE Booking_Id = {id} AND Status != 'Cancelled'";

            OracleDataReader reader = _db.ExecuteSingleRowQuery(query);
            return reader;
        }

        internal static DataSet GetActiveByCustomerId(int customerId)
        {
            string query = $@"
                SELECT *
                FROM Bookings
                WHERE Customer_Id = {customerId} AND Status NOT IN ('Checked-Out', 'Cancelled')";

            DataSet ds = _db.ExecuteMultiRowQuery(query);
            return ds;
        }

        internal static DataSet GetActiveByPetId(int petId)
        {
            string query = $@"
                SELECT *
                FROM Bookings
                WHERE Pet_Id = {petId} AND Status NOT IN ('Checked-Out', 'Cancelled')";

            DataSet ds = _db.ExecuteMultiRowQuery(query);
            return ds;
        }

        internal static DataSet GetActiveByServiceId(int serviceId) 
        {
            string query = $@"
                SELECT *
                FROM Bookings
                WHERE Service_Id = {serviceId} AND Status NOT IN ('Checked-Out', 'Cancelled')";

            DataSet ds = _db.ExecuteMultiRowQuery(query);
            return ds;
        }

        internal static DataSet GetActiveByDateRange(DateTime startDateTime, DateTime endDateTime, int serviceId)
        {
            string query = $@"
                SELECT *
                FROM Bookings
                WHERE Service_Id = {serviceId} 
                  AND Status NOT IN ('Checked-Out', 'Cancelled')
                  AND Check_In < TO_DATE('{startDateTime:dd-MM-yyyy HH:mm}', 'DD-MM-YYYY HH24:MI') AND Check_Out > TO_DATE('{startDateTime:dd-MM-yyyy HH:mm}', 'DD-MM-YYYY HH24:MI')";
            
            DataSet ds = _db.ExecuteMultiRowQuery(query);
            return ds;
        }

        internal static void Insert(Booking booking)
        {
            string query = $@"
                INSERT INTO Bookings (Check_In, Check_Out, Price_Per_Hour, Actual_Price, Service_ID, Customer_ID, Pet_ID)
                VALUES (TO_DATE('{booking.CheckIn:dd-MM-yyyy HH:mm}', 'DD-MM-YYYY HH24:MI'),
                        TO_DATE('{booking.CheckOut:dd-MM-yyyy HH:mm}', 'DD-MM-YYYY HH24:MI'),
                        {booking.PricePerHour},
                        {booking.ActualPrice},
                        {booking.ServiceId},
                        {booking.CustomerId},
                        {booking.PetId})";

            _db.ExecuteNonQuery(query);
        }

        internal static void Update(Booking booking)
        {
            string query = $@"
                UPDATE Bookings
                SET Check_In = TO_DATE('{booking.CheckIn:dd-MM-yyyy HH:mm}', 'DD-MM-YYYY HH24:MI'),
                    Check_Out = TO_DATE('{booking.CheckOut:dd-MM-yyyy HH:mm}', 'DD-MM-YYYY HH24:MI'),
                    Price_Per_Hour = {booking.PricePerHour},
                    Actual_Price = {booking.ActualPrice},
                    Service_ID = {booking.ServiceId},
                    Customer_ID = {booking.CustomerId},
                    Pet_ID = {booking.PetId}
                WHERE Booking_Id = {booking.Id}";

            _db.ExecuteNonQuery(query);
        }

        internal static void UpdateStatus(int id, string status)
        {
            string query = $@"
                UPDATE Bookings
                SET Status = '{status}'
                WHERE Booking_Id = {id}";

            _db.ExecuteNonQuery(query);
        }

        internal static void Deactivate(int id) 
        {
            string query = $@"
                UPDATE Bookings
                SET Status = 'Cancelled'
                WHERE Booking_Id = {id}";

            _db.ExecuteNonQuery(query);
        }
    }
}
