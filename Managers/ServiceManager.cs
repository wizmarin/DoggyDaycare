using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoggyDaycare.Data.Mappers;
using DoggyDaycare.Data.Repositories;
using DoggyDaycare.Models;
using DoggyDaycare.Exceptions;

namespace DoggyDaycare.Managers
{
    internal class ServiceManager
    {
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
                    MessageBox.Show("Deactivation process was aborted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    ServiceRepo.Deactivate(service.Id);
                    MessageBox.Show("Service has been deactivated successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
