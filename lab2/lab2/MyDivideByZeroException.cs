using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class MyDivideByZeroException : DivideByZeroException
    {
        public MyDivideByZeroException()
        {
        }

        public MyDivideByZeroException(string message) : base(message)
        {
            Console.Write(message);

        }

        public MyDivideByZeroException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MyDivideByZeroException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
