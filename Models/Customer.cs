using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoggyDaycare.Models
{
    internal class Customer
    {
        private int _id;
        private string _status;
        private string _firstName;
        private string _lastName;
        private string _email;
        private string _phoneNumber;
        private string? _emergencyContactName;
        private string? _emergencyContactPhone;

        public required int Id { get; init; }
        public required string Status { get; set; }
        public required string FullName { get; set; }
        public required string Email { get; set; }
        public required string PhoneNumber { get; set; }
        public string? EmergencyContactName { get; set; }
        public string? EmergencyContactPhone { get; set; }

        public Customer(int id, 
                        string status, 
                        string firstName, 
                        string lastName, 
                        string email, 
                        string phoneNumber, 
                        string? emergencyContactName = null, 
                        string? emergencyContactPhone = null)
        {
            Id = id;
            Status = status;
            FullName = $"{firstName} {lastName}";
            Email = email;
            PhoneNumber = phoneNumber;
            EmergencyContactName = emergencyContactName;
            EmergencyContactPhone = emergencyContactPhone;
        }

        public string ToString()
        {
            return $"Customer ID: {Id}, Name: {FullName}, Email: {Email}, Phone: {PhoneNumber}, Emergency Contact: {EmergencyContactName} ({EmergencyContactPhone})";
        }
    }
}
