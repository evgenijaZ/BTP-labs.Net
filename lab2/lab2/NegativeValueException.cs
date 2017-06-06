using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class NegativeValueException : Exception
    {
        public NegativeValueException()
        {
        }

        public NegativeValueException(string message) : base(message)
        {
        }

        public NegativeValueException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NegativeValueException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
