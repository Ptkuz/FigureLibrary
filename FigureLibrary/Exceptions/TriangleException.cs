using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary.Exceptions
{
    public class TriangleException : Exception
    {

        public TriangleException(string message, Exception innerException) 
        {
            
        }

        public TriangleException(string message)
            : base(message) 
        {
            
        }

    }
}
