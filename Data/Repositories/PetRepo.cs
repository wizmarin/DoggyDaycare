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
    internal static class PetRepo
    {
        private static DatabaseConnection _db = DatabaseConnection.GetInstance();

        internal static DataSet GetAll()
        {
            string query = $@"
                SELECT * 
                FROM Pets 
                WHERE Status = 'Active'";

            DataSet ds = _db.ExecuteMultiRowQuery(query);
            return ds;
        }

        internal static OracleDataReader GetById(int id)
        {
            string query = $@"
                SELECT * 
                FROM Pets 
                WHERE Pet_Id = {id} AND Status = 'Active'";

            OracleDataReader reader = _db.ExecuteSingleRowQuery(query);
            return reader;
        }

        internal static OracleDataReader GetByOwnerId(int ownerId)
        {
            string query = $@"
                SELECT *
                FROM Pets
                WHERE Owner_Id = {ownerId} AND Status = 'Active'";

            OracleDataReader reader = _db.ExecuteSingleRowQuery(query);
            return reader;
        }

        internal static void Insert(Pet pet)
        {
            string query = $@"
                INSERT INTO Pets (Status, Owner_Id, Name, Age, Sex, Vet_Check_Up, Feeding_Notes, Medical_Conditions, Socialisation_Level, Known_Triggers, Behavioural_Notes, Additional_Notes)
                VALUES ('{pet.Status}', {pet.OwnerId}, '{pet.Name}', {pet.Age}, '{pet.Sex}', '{pet.VetCheckUp}', '{pet.FeedingNotes}', '{pet.MedicalConditions}', '{pet.SocialisationLevel}', '{pet.KnownTriggers}', '{pet.BehaviouralNotes}', '{pet.AdditionalNotes}')";

            _db.ExecuteNonQuery(query);
        }

        internal static void Update(Pet pet)
        {
            string query = $@"
                UPDATE Pets
                SET Owner_Id = {pet.OwnerId}, Name = '{pet.Name}', Age = {pet.Age}, Sex = '{pet.Sex}', Vet_Check_Up = '{pet.VetCheckUp}', Feeding_Notes = '{pet.FeedingNotes}', Medical_Conditions = '{pet.MedicalConditions}', Socialisation_Level = '{pet.SocialisationLevel}', Known_Triggers = '{pet.KnownTriggers}', Behavioural_Notes = '{pet.BehaviouralNotes}', Additional_Notes = '{pet.AdditionalNotes}'
                WHERE Pet_Id = {pet.Id}";

            _db.ExecuteNonQuery(query);
        }

        internal static void Deactivate(int id)
        {
            string query = $@"
                UPDATE Pets
                SET Status = 'Inactive'
                WHERE Pet_Id = {id}";

            _db.ExecuteNonQuery(query);
        }

    }
}
