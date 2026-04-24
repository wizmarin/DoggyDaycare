using System.Data;
using DoggyDaycare.Data.Mappers;
using DoggyDaycare.Data.Repositories;
using DoggyDaycare.Exceptions;
using DoggyDaycare.Forms;
using DoggyDaycare.Models;
using Oracle.ManagedDataAccess.Client;

namespace DoggyDaycare.Managers
{
    internal static class ServiceManager
    {
        internal static List<Service> GetAllServices()
        {
            DataSet ds = ServiceRepo.GetAll();
            List<Service> services = DataSetMapper.MapToList<Service>(ds);
            return services;
        }

        internal static Service GetServiceById(int id)
        {
            OracleDataReader reader = ServiceRepo.GetById(id);
            Service service = OracleDataReaderMapper.MapToObject<Service>(reader);
            return service;
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

            var mainForm = Application.OpenForms.OfType<frmMain>().FirstOrDefault();
            var loadOption = "Hide";

            mainForm.OpenChildForm(new frmUpdateService(service), loadOption);
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

            var mainForm = Application.OpenForms.OfType<frmMain>().FirstOrDefault();
            var loadOption = "Close";

            if (result == DialogResult.Cancel)
            {
                mainForm.OpenChildForm(new frmServices(), loadOption);
                return;
            }

            if (result == DialogResult.No)
            {
                return;
            }

            ServiceRepo.Insert(newService);
            MessageBox.Show("Service has been added successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            mainForm.OpenChildForm(new frmServices(), loadOption);
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

            var mainForm = Application.OpenForms.OfType<frmMain>().FirstOrDefault();
            var servicesForm = Application.OpenForms.OfType<frmServices>().FirstOrDefault();
            var loadOption = "Close";

            if (result == DialogResult.Cancel)
            {
                mainForm.OpenChildForm(servicesForm, loadOption);
                return;
            }

            if (result == DialogResult.No)
            {
                return;
            }

            service.Name = name;
            service.BreedType = breedType;
            service.PricePerHour = pricePerHour;
            service.MaxCapacityPerSlot = maxCapacityPerSlot;

            ServiceRepo.Update(service);
            MessageBox.Show("Service has been updated successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            servicesForm.UpdateDataSource(service, "update");
            mainForm.OpenChildForm(servicesForm, loadOption);
        }

        internal static void DeactivateService(Service service)
        {
            if (service == null)
            {
                throw new NoSelectionException("No service selected. Please select a service to deactivate.");
            }

            List<Booking> bookings = BookingManager.GetActiveBookingsByServiceId(service.Id);
            if (bookings.Count > 0)
            {
                throw new InvalidOperationException("Cannot deactivate service with active or future bookings.");
            }

            string message = $"You are about to deactivate service:\n\n{service.ToString()}\n\nThis action cannot be undone.";

            DialogResult result = MessageBox.Show(message, "Confirm Deactivation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.Cancel)
            {
                throw new DeactivationAbortedException();
            }

            ServiceRepo.Deactivate(service.Id);
            MessageBox.Show("Service has been deactivated successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                errorMessage += "Service Name: " + nameValidation + "\n";
            }

            if (priceValidation != "valid")
            {
                errorMessage += "Price: " + priceValidation + "\n";
            }

            if (capacityValidation != "valid")
            {
                errorMessage += "Max Capacity: " + capacityValidation + "\n";
            }

            return errorMessage;
        }

        private static string IsValidName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return "Service name cannot be empty.";
            }

            return "valid";
        }

        private static string IsValidPrice(float price)
        {
            if (price <= 0)
            {
                return "Price per hour must be greater than zero.";
            }

            return "valid";
        }

        private static string IsValidCapacity(int capacity)
        {
            if (capacity <= 0)
            {
                return "Max capacity per slot must be greater than zero.";
            }

            return "valid";
        }

    }
}
