using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoggyDaycare.Data.Repositories;
using DoggyDaycare.Models;

namespace DoggyDaycare.Managers
{
    internal class ServiceManager
    {
        internal static List<Service> GetSmallBreed()
        {
            List<Service> services = ServiceRepo.GetAll();
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
            List<Service> services = ServiceRepo.GetAll();
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
            List<Service> services = ServiceRepo.GetAll();
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


    }
}
