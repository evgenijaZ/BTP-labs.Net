using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class MyStackOverflowException : Exception
    {
        public MyStackOverflowException()
        {
        }

        public MyStackOverflowException(string message) : base(message)
        {
        }

        public MyStackOverflowException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MyStackOverflowException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
