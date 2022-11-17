using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPreservas
{
    internal class otraException : ApplicationException
    {
        
            public otraException() : base()
            {
            }
            public otraException(string message) : base(message) { }
            public otraException(string message, Exception innerException) : base(message, innerException) { }

        
    }
}
