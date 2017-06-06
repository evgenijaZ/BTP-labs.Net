using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class MyArrayTypeMismatchException : ArrayTypeMismatchException
    {
        public MyArrayTypeMismatchException()
        {

        }

        public MyArrayTypeMismatchException(string message) : base(message)
        {
            Console.Write(message);

        }

        public MyArrayTypeMismatchException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MyArrayTypeMismatchException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
