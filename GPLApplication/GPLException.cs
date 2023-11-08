using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPLApplication
{
    internal class GPLException : Exception
    {
        public GPLException(string message) : base(message)
        {

        }
        public GPLException(string message, Exception inner) : base(message, inner)
        {
            
        }
    }
}
