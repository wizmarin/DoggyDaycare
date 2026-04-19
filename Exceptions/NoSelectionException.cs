using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoggyDaycare.Exceptions
{
    internal class NoSelectionException : Exception
    {
        public NoSelectionException() : base("No selection was made. Please select an item.") { }
        public NoSelectionException(string message) : base(message) { }
        public NoSelectionException(string message, Exception innerException) : base(message, innerException) { }
    }
}
