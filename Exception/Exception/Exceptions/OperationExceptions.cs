using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception.Exceptions
{
    internal class OperationExceptions: SystemException
        {
        public OperationExceptions(): this("Not Negative")
        {
            
        }
        public OperationExceptions(string message): base (message)
        {
            
        }
    }
}
