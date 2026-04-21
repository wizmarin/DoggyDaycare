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
    internal static class ServiceRepo
    {
        private static DatabaseConnection _db = DatabaseConnection.GetInstance();

        internal static DataSet GetAll()
        {
            string query = $@"
                SELECT * 
                FROM Services 
                WHERE Status = 'Active'";

            DataSet ds = _db.ExecuteMultiRowQuery(query);
            return ds;
        }

        internal static OracleDataReader GetById(int id)
        {
            string query = $@"
                SELECT * 
                FROM Services 
                WHERE Service_Id = {id} AND Status = 'Active'";

            OracleDataReader reader = _db.ExecuteSingleRowQuery(query);

            return reader;
        }

        internal static void Insert(Service service)
        {
            string query = $@"
                INSERT INTO Services (Name, Breed_Type, Price_Per_Hour, Max_Capacity_Per_Slot) 
                VALUES ('{service.Name}', '{service.BreedType}', {service.PricePerHour}, {service.MaxCapacityPerSlot})";

            _db.ExecuteNonQuery(query);
        }

        internal static void Update(Service service)
        {
            string query = $@"
                UPDATE Services 
                SET Name = '{service.Name}', Breed_Type = '{service.BreedType}', Price_Per_Hour = {service.PricePerHour}, Max_Capacity_Per_Slot = {service.MaxCapacityPerSlot}
                WHERE Service_Id = {service.Id}";

            _db.ExecuteNonQuery(query);
        }

        internal static void Deactivate(int id)
        {
            string query = $@"
                UPDATE Services 
                SET Status = 'Inactive' 
                WHERE Service_Id = {id}";

            _db.ExecuteNonQuery(query);
        }
    }
}
