using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoggyDaycare.Exceptions
{
    internal class UserNotFoundException : Exception
    {
        public UserNotFoundException() : base("User with such name not found.") { }

        public UserNotFoundException(string message) : base(message) { }

        public UserNotFoundException(string message, Exception innerException) : base(message, innerException) { }
    }
}
