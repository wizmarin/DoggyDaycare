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
    internal class CustomerRepo
    {
        private static DatabaseConnection _db = DatabaseConnection.GetInstance();

        internal static DataSet GetAll() 
        {
            string query = $@"
                SELECT * 
                FROM Customers 
                WHERE Status = 'Active'";

            DataSet ds = _db.ExecuteMultiRowQuery(query);
            return ds;
        }

        internal static OracleDataReader GetByPhone(string phone) 
        {
            string query = $@"
                SELECT * 
                FROM Customers 
                WHERE Phone_Number = '{phone}' AND Status = 'Active'";

            OracleDataReader reader = _db.ExecuteSingleRowQuery(query);

            return reader;
        }

        internal static OracleDataReader GetByEmail(string email)
        {
            string query = $@"
                SELECT * 
                FROM Customers 
                WHERE Email = '{email}' AND Status = 'Active'";

            OracleDataReader reader = _db.ExecuteSingleRowQuery(query);
            
            return reader;
        }

        internal static OracleDataReader GetById(int id) 
        {
            string query = $@"
                SELECT * 
                FROM Customers 
                WHERE Customer_Id = {id} AND Status = 'Active'";

            OracleDataReader reader = _db.ExecuteSingleRowQuery(query);
            
            return reader;
        }

        internal static void Insert(Customer customer) 
        {
            string query = $@"
                INSERT INTO Customers (Full_Name, Email, Phone_Number, Emerg_Contact, Emerg_Contact_Number) 
                VALUES ('{customer.FullName}', '{customer.Email}', '{customer.PhoneNumber}', '{customer.EmergencyContactName}', '{customer.EmergencyContactPhone}')";

            _db.ExecuteNonQuery(query);
        }

        internal static void Update(Customer customer) 
        {
            string query = $@"
                UPDATE Customers 
                SET Full_Name = '{customer.FullName}', Email = '{customer.Email}', Phone_Number = '{customer.PhoneNumber}',
                    Emerg_Contact = '{customer.EmergencyContactName}', Emerg_Contact_Number = '{customer.EmergencyContactPhone}'
                WHERE Customer_Id = {customer.Id}";

            _db.ExecuteNonQuery(query);
        }

        internal static void Deactivate(int id) 
        {
            string query = $@"
                UPDATE Customers 
                SET Status = 'Inactive' 
                WHERE Customer_Id = {id}";

            _db.ExecuteNonQuery(query);
        }
    }
}
