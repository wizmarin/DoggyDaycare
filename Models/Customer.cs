using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoggyDaycare.Data.Attributes;

namespace DoggyDaycare.Models
{
    public class Customer
    {
        [ColumnName("CUSTOMER_ID")]
        public int Id { get; set; }
        [ColumnName("STATUS")]
        public string Status { get; set; }
        [ColumnName("FULL_NAME")]
        public string FullName { get; set; }
        [ColumnName("EMAIL")]
        public string Email { get; set; }
        [ColumnName("PHONE_NUMBER")]
        public string PhoneNumber { get; set; }
        [ColumnName("EMERG_CONTACT")]
        public string? EmergencyContactName { get; set; }
        [ColumnName("EMERG_CONTACT_NUMBER")]
        public string? EmergencyContactPhone { get; set; }

        public Customer() { }

        public Customer(string fullName,
                        string email,
                        string phoneNumber,
                        string? emergencyContactName = null,
                        string? emergencyContactPhone = null)
        {
            SetStatus("Active");
            SetFullName(fullName);
            SetEmail(email);
            SetPhoneNumber(phoneNumber);
            SetEmergencyContactName(emergencyContactName);
            SetEmergencyContactPhone(emergencyContactPhone);
        }

        public Customer(int id,
                        string status,
                        string fullName,
                        string email,
                        string phoneNumber,
                        string? emergencyContactName = null,
                        string? emergencyContactPhone = null)
        {
            SetId(id);
            SetStatus(status);
            SetFullName(fullName);
            SetEmail(email);
            SetPhoneNumber(phoneNumber);
            SetEmergencyContactName(emergencyContactName);
            SetEmergencyContactPhone(emergencyContactPhone);
        }

        private void SetId(int id)
        {
            Id = id;
        }

        private void SetStatus(string status)
        {
            Status = status;
        }

        internal void SetFullName(string fullName)
        {
            FullName = fullName;
        }

        internal void SetEmail(string email)
        {
            Email = email;
        }

        internal void SetPhoneNumber(string phoneNumber)
        {
            PhoneNumber = phoneNumber;
        }

        internal void SetEmergencyContactName(string? emergencyContactName)
        {
            EmergencyContactName = emergencyContactName;
        }

        internal void SetEmergencyContactPhone(string? emergencyContactPhone)
        {
            EmergencyContactPhone = emergencyContactPhone;
        }

        public string ToString()
        {
            return $"Customer ID: {Id}\nFull Name: {FullName}\nEmail: {Email}\nPhone: {PhoneNumberDisplay(PhoneNumber)}\nEmergency Contact: {EmergencyContactNameDisplay(EmergencyContactName)}\nEmergency Contact Phone: {PhoneNumberDisplay(EmergencyContactPhone)}";
        }

        private string PhoneNumberDisplay(string phoneNumber)
        {
            if (string.IsNullOrEmpty(phoneNumber))
            {
                return "N/A";
            }

            return $"({phoneNumber[0..3]}) {phoneNumber[3..6]}-{phoneNumber[6..10]}";
        }

        private string EmergencyContactNameDisplay(string emergencyContactName)
        {
            if (string.IsNullOrEmpty(emergencyContactName))
            {
                return "N/A";
            }
            return emergencyContactName;
        }

    }
}
