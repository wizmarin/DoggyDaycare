using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoggyDaycare.Exceptions
{
    internal class DeactivationAbortedException : Exception
    {
        public DeactivationAbortedException() : base("Deactivation process was aborted.")
        {
        }
        public DeactivationAbortedException(string message) : base(message)
        {
        }
        public DeactivationAbortedException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
