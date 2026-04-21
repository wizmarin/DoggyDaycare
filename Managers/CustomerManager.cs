using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DoggyDaycare.Data.Mappers;
using DoggyDaycare.Data.Repositories;
using DoggyDaycare.Exceptions;
using DoggyDaycare.Forms;
using DoggyDaycare.Models;
using Oracle.ManagedDataAccess.Client;

namespace DoggyDaycare.Managers
{
    internal class CustomerManager
    {
        private static frmMain mainForm = Application.OpenForms.OfType<frmMain>().FirstOrDefault();
        private static frmCustomers customersForm = Application.OpenForms.OfType<frmCustomers>().FirstOrDefault();
        private static string loadOption;

        internal static List<Customer> GetAllCustomers()
        {
            DataSet ds = CustomerRepo.GetAll();
            List<Customer> customers = DataSetMapper.MapToList<Customer>(ds);
            return customers;
        }

        internal static void LoadUpdateForm(Customer customer)
        {
            if (customer == null)
            {
                throw new NoSelectionException("No customer selected. Please select a customer to update.");
            }
            else
            {
                loadOption = "Hide";
                mainForm.OpenChildForm(new frmUpdateCustomer(customer), loadOption);
            }
        }

        internal static void RegisterCustomer(string fullName, string email, string phone, string? emergencyContactName, string? emergencyContactPhone)
        {
            string message = IsValidInput(default, fullName, email, phone, emergencyContactName, emergencyContactPhone);

            if (message != "valid")
            {
                MessageBox.Show(message, "Input Not Valid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            phone = new string(phone.Where(char.IsDigit).ToArray());

            if (string.IsNullOrEmpty(emergencyContactName))
            {
                emergencyContactName = null;
            }
            else
            {
                emergencyContactPhone = new string(emergencyContactPhone.Where(char.IsDigit).ToArray());
            }

            Customer newCustomer = new Customer(fullName, email, phone, emergencyContactName, emergencyContactPhone);

            message = $"You are about to register the following customer:\n\n{newCustomer.ToString()}\n\nWould you like to proceed?";

            DialogResult result = MessageBox.Show(message, "Confirm Registration", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Cancel)
            {
                loadOption = "Close";
                mainForm.OpenChildForm(new frmCustomers(), loadOption);
                return;
            }
            else if (result == DialogResult.No)
            {
                return;
            }
            else
            {
                CustomerRepo.Insert(newCustomer);

                MessageBox.Show("Customer has been registered successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                loadOption = "Close";
                mainForm.OpenChildForm(new frmCustomers(), loadOption);
            }
        }

        internal static void UpdateCustomer(Customer customer, string fullName, string email, string phone, string? emergencyContactName, string? emergencyContactPhone)
        {
            string message = IsValidInput(customer, fullName, email, phone, emergencyContactName, emergencyContactPhone);

            if (message != "valid")
            {
                MessageBox.Show(message, "Input Not Valid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            message = $"You are about to update the customer:\n\n{customer.ToString()}\n\nWith the following details:\n\n";

            if (customer.FullName != fullName)
            {
                message += $"Full Name: {fullName}\n";
            }

            if (customer.Email != email)
            {
                message += $"Email: {email}\n";
            }

            if (customer.PhoneNumber != phone)
            {
                message += $"Phone: {phone}\n";
            }

            if (customer.EmergencyContactName != emergencyContactName)
            {
                message += $"Emergency Contact Name: {emergencyContactName}\n";
            }

            if (customer.EmergencyContactPhone != emergencyContactPhone)
            {
                message += $"Emergency Contact Phone: {emergencyContactPhone}\n";
            }

            message += "\nWould you like to proceed with the update?";

            DialogResult result = MessageBox.Show(message, "Confirm Update", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Cancel)
            {
                loadOption = "Close";
                mainForm.OpenChildForm(customersForm, loadOption);
                return;
            }
            else if (result == DialogResult.No)
            {
                return;
            }
            else
            {
                customer.SetFullName(fullName);
                customer.SetEmail(email);
                customer.SetPhoneNumber(phone);
                customer.SetEmergencyContactName(emergencyContactName);
                customer.SetEmergencyContactPhone(emergencyContactPhone);

                CustomerRepo.Update(customer);

                MessageBox.Show("Customer has been updated successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                customersForm.UpdateDataSource(customer, "update");

                loadOption = "Close";
                mainForm.OpenChildForm(customersForm, loadOption);
            }
        }

        internal static void DeactivateCustomer(Customer customer)
        {
            // TODO: Implement check for active reservations for assigned pets and display message to user if there are any active reservations, preventing deactivation of customer until all active reservations are resolved
            // TODO: Implement part with deactivating all assigned pets

            if (customer == null)
            {
                throw new NoSelectionException("No customer selected. Please select a customer to deactivate.");
            }
            else
            {
                string message = $"You are about to deactivate customer:\n\n{customer.ToString()}\n\nThis action cannot be undone.";
                
                DialogResult result = MessageBox.Show(message, "Confirm Deactivation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.Cancel)
                {
                    throw new DeactivationAbortedException();
                }
                else 
                {
                    CustomerRepo.Deactivate(customer.Id);
                    MessageBox.Show("Customer has been deactivated successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private static string IsValidInput(Customer customer, string fullName, string email, string phone, string? emergencyContactName, string? emergencyContactPhone)
        {
            string fullNameValidation = IsValidFullName(fullName);
            string emailValidation = IsValidEmail(email);
            string phoneValidation = IsValidPhone(phone);
            string emergencyContactNameValidation = IsValidEmergencyContactName(emergencyContactName);
            string emergencyContactPhoneValidation = IsValidEmergencyContactPhone(emergencyContactPhone);

            string uniquePhoneValidation = IsUniquePhone(phone, customer);
            string uniqueEmailValidation = IsUniqueEmail(email, customer);

            if (fullNameValidation == "valid" &&
                emailValidation == "valid" &&
                phoneValidation == "valid" &&
                emergencyContactNameValidation == "valid" &&
                emergencyContactPhoneValidation == "valid" &&
                uniquePhoneValidation == "valid" &&
                uniqueEmailValidation == "valid")
            {

                return "valid";

            }

            string errorMessage = "Please correct the following errors:\n\n";

            if (fullNameValidation != "valid")
            {
                errorMessage += "Full Name:" + fullNameValidation + "\n";
            }
            if (emailValidation != "valid")
            {
                errorMessage += "Email: " + emailValidation + "\n";
            }
            if (uniqueEmailValidation != "valid")
            {
                errorMessage += "Email: " + uniqueEmailValidation + "\n";
            }
            if (phoneValidation != "valid")
            {
                errorMessage += "Phone: " + phoneValidation + "\n";
            }
            if (uniquePhoneValidation != "valid")
            {
                errorMessage += "Phone: " + uniquePhoneValidation + "\n";
            }
            if (emergencyContactNameValidation != "valid")
            {
                errorMessage += "Emergency Contact Name: " + emergencyContactNameValidation + "\n";
            }
            if (emergencyContactPhoneValidation != "valid")
            {
                errorMessage += "Emergency Contact Phone: " + emergencyContactPhoneValidation + "\n";
            }

            return errorMessage;
        }

        private static string IsValidFullName(string fullName)
        {
            if (string.IsNullOrWhiteSpace(fullName))
            {
                return "Full name cannot be empty.";
            }

            int spaceCount = 0;

            if (fullName.StartsWith(" ") || fullName.EndsWith(" "))
            {
                return "Full name cannot start or end with a space.";
            }

            foreach (char c in fullName)
            {
                if (c == ' ')
                {
                    spaceCount++;
                }
                else if (!char.IsLetter(c))
                {
                    return "Full name can only contain letters and space.";
                }
            }

            if (spaceCount > 1)
            {
                return "Full name cannot contain more than one space.";
            }

            if (spaceCount == 0)
            {
                return "Full name must contain at least a first name and a last name.";
            }

            return "valid";
        }

        private static string IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return "Email cannot be empty.";
            }

            string pattern = @"^[a-zA-Z0-9_%+\-]+(\.[a-zA-Z0-9_%+\-]+)*@[a-zA-Z0-9]+(-[a-zA-Z0-9]+)*(\.[a-zA-Z0-9]+(-[a-zA-Z0-9]+)*)*\.[a-zA-Z]{2,}$";

            if (!Regex.IsMatch(email, pattern))
            {
                return "Invalid email format.";
            }

            return "valid";
        }

        private static string IsValidPhone(string phone)
        {
            if (string.IsNullOrWhiteSpace(phone))
            {
                return "Phone number cannot be empty.";
            }

            string cleanedPhone = new string(phone.Where(char.IsDigit).ToArray());

            string pattern = @"^\d{10}$";
            if (!Regex.IsMatch(cleanedPhone, pattern))
            {
                return "Invalid phone number format.";
            }

            return "valid";
        }

        private static string IsValidEmergencyContactName(string? emergencyContactName)
        {
            if (!string.IsNullOrEmpty(emergencyContactName))
            {
                if (emergencyContactName.All(c => c == ' '))
                {
                    return "Emergency contact name cannot contain only spaces.";
                }

                return IsValidFullName(emergencyContactName);
            }

            return "valid";
        }

        private static string IsValidEmergencyContactPhone(string? emergencyContactPhone)
        {
            if (!string.IsNullOrEmpty(emergencyContactPhone))
            {
                return IsValidPhone(emergencyContactPhone);
            }

            return "valid";
        }

        private static string IsUniquePhone(string phone, Customer? customer)
        {
            OracleDataReader reader = CustomerRepo.GetByPhone(phone);
            List<Customer> customers = OracleDataReaderMapper.MapToList<Customer>(reader);

            if (customer == null && customers.Count > 0) 
            {
                return "Phone number already exists. Please enter a unique phone number.";
            }

            if (customer != null && customers.Any(c => c.Id != customer.Id))
            {
                return "Phone number already exists. Please enter a unique phone number.";
            }

            return "valid";
        }

        private static string IsUniqueEmail(string email, Customer? customer)
        {
            OracleDataReader reader = CustomerRepo.GetByEmail(email);
            List<Customer> customers = OracleDataReaderMapper.MapToList<Customer>(reader);

            if (customer == null && customers.Count > 0) 
            {
                return "Email already exists. Please enter a unique email.";
            }

            if (customer != null && customers.Any(c => c.Id != customer.Id))
            {
                return "Email already exists. Please enter a unique email.";
            }

            return "valid";
        }

    }
}           
      
