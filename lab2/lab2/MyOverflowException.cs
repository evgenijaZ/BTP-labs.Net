using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class MyOverflowException : OverflowException
    {
        public MyOverflowException()
        {
        }

        public MyOverflowException(string message) : base(message)
        {
        }

        public MyOverflowException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MyOverflowException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
