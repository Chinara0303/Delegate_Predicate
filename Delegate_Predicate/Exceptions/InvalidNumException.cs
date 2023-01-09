using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLayer.Exceptions
{
    public class InvalidNumException : Exception
    {
        public InvalidNumException(string msg) : base(msg) { }
       
    }
}
