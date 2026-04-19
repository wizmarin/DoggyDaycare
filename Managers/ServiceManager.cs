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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace DoggyDaycare.Managers
{
    internal class ServiceManager
    {
        private static frmMain mainForm = Application.OpenForms.OfType<frmMain>().FirstOrDefault();
        private static frmServices servicesForm = Application.OpenForms.OfType<frmServices>().FirstOrDefault();
        private static string loadOption;

        internal static List<Service> GetAllServices()
        {
            DataSet ds = ServiceRepo.GetAll();
            List<Service> services = DataSetMapper.MapToList<Service>(ds);
            return services;
        }

        internal static List<Service> GetSmallBreed()
        {
            DataSet ds = ServiceRepo.GetAll();
            List<Service> services = DataSetMapper.MapToList<Service>(ds);
            List<Service> result = new List<Service>();

            foreach (Service service in services)
            {
                if (service.BreedType == "Small")
                {
                    result.Add(service);
                }
            }
            
            return result;
        }

        internal static List<Service> GetMediumBreed()
        {
            DataSet ds = ServiceRepo.GetAll();
            List<Service> services = DataSetMapper.MapToList<Service>(ds);
            List<Service> result = new List<Service>();

            foreach (Service service in services)
            {
                if (service.BreedType == "Medium")
                {
                    result.Add(service);
                }
            }
            
            return result;
        }

        internal static List<Service> GetBigBreed()
        {
            DataSet ds = ServiceRepo.GetAll();
            List<Service> services = DataSetMapper.MapToList<Service>(ds);
            List<Service> result = new List<Service>();

            foreach (Service service in services)
            {
                if (service.BreedType == "Big")
                {
                    result.Add(service);
                }
            }

            return result;
        }

        internal static void LoadUpdateForm(Service service)
        {
            if (service == null)
            {
                throw new NoSelectionException("No service selected. Please select a service to update.");
            }
            else
            {
                loadOption = "Hide";
                mainForm.OpenChildForm(new frmUpdateService(service), loadOption);
            }
        }

        internal static void AddService(string name, string breedType, float pricePerHour, int maxCapacityPerSlot)
        {
            string message = IsValidInput(name, pricePerHour, maxCapacityPerSlot);

            if (message != "valid")
            {
                MessageBox.Show(message, "Input Not Valid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Service newService = new Service(name, breedType, pricePerHour, maxCapacityPerSlot);

            message = $"You are about to add the following service:\n\n{newService.ToString()}\n\nWould you like to proceed?";

            DialogResult result = MessageBox.Show(message, "Confirm Addition", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Cancel)
            {
                loadOption = "Close";
                mainForm.OpenChildForm(new frmServices(), loadOption);
                return;
            }
            else if (result == DialogResult.No)
            {
                return;
            }
            else
            {
                ServiceRepo.Insert(newService);

                MessageBox.Show("Service has been added successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                loadOption = "Close";
                mainForm.OpenChildForm(new frmServices(), loadOption);
            }
        }

        internal static void UpdateService(Service service, string name, string breedType, float pricePerHour, int maxCapacityPerSlot)
        {
            string message = IsValidInput(name, pricePerHour, maxCapacityPerSlot);

            if (message != "valid")
            {
                MessageBox.Show(message, "Input Not Valid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            message = $"You are about to update service:\n\n{service.ToString()}\n\nWith the following details:\n\n";

            if (service.Name != name)
            {
                message += $"Name: {name}\n";
            }

            if (service.BreedType != breedType)
            {
                message += $"Breed Type: {breedType}\n";
            }

            if (service.PricePerHour != pricePerHour)
            {
                message += $"Price Per Hour: {pricePerHour}\n";
            }

            if (service.MaxCapacityPerSlot != maxCapacityPerSlot)
            {
                message += $"Max Capacity Per Slot: {maxCapacityPerSlot}\n";
            }

            message += "\nWould you like to proceed with the update?";

            DialogResult result = MessageBox.Show(message, "Confirm Update", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Cancel)
            {
                loadOption = "Close";
                mainForm.OpenChildForm(servicesForm, loadOption);
                return;
            }
            else if (result == DialogResult.No)
            {
                return;
            }
            else
            {
                service.SetName(name);
                service.SetBreedType(breedType);
                service.SetPricePerHour(pricePerHour);
                service.SetMaxCapacityPerSlot(maxCapacityPerSlot);
                
                ServiceRepo.Update(service);
                
                MessageBox.Show("Service has been updated successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                servicesForm.UpdateDataSource(service, "update");

                loadOption = "Close";
                mainForm.OpenChildForm(servicesForm, loadOption);
            }
        }

        internal static void DeactivateService(Service service)
        {
            // TODO: Implement a check to see if there are any active or future bookings for this service before deactivating it. If there are, throw an exception.

            if (service == null) 
            {
                throw new NoSelectionException("No service selected. Please select a service to deactivate.");
            }
            else
            {
                string message = $"You are about to deactivate service:\n\n{service.ToString()}\n\nThis action cannot be undone.";
                
                DialogResult result = MessageBox.Show(message, "Confirm Deactivation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                
                if (result == DialogResult.Cancel)
                {
                    throw new DeactivationAbortedException();
                }
                else
                {
                    ServiceRepo.Deactivate(service.Id);
                    MessageBox.Show("Service has been deactivated successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private static string IsValidInput(string name, float price, int capacity)
        {
            string nameValidation = IsValidName(name);
            string priceValidation = IsValidPrice(price);
            string capacityValidation = IsValidCapacity(capacity);

            if (nameValidation == "valid" && priceValidation == "valid" && capacityValidation == "valid")
            {
                return "valid";
            }
            
            string errorMessage = "Please correct the following errors:\n\n";

            if (nameValidation != "valid")
            {
                errorMessage += nameValidation + "\n";
            }
            if (priceValidation != "valid")
            {
                errorMessage += priceValidation + "\n";
            }
            if (capacityValidation != "valid")
            {
                errorMessage += capacityValidation + "\n";
            }

            return errorMessage;
        }

        private static string IsValidName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return "Service name cannot be empty.";
            }
            else
            {
                return "valid";
            }
        }

        private static string IsValidPrice(float price)
        {
            if (price <= 0)
            {
                return "Price per hour must be greater than zero.";
            }
            else
            {
                return "valid";
            }
        }

        private static string IsValidCapacity(int capacity)
        {
            if (capacity <= 0)
            {
                return "Max capacity per slot must be greater than zero.";
            }
            else
            {
                return "valid";
            }
        }

    }
}
