using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoggyDaycare.Exceptions
{
    internal class PasswordMismatchException : Exception
    {
        public PasswordMismatchException() : base("The password you entered is incorrect.") { }

        public PasswordMismatchException(string message) : base(message) { }

        public PasswordMismatchException(string message, Exception innerException) : base(message, innerException) { }
    }
}
