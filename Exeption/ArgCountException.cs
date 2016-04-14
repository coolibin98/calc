using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    class ArgCountException:Exception
    {
        public ArgCountException (string message):base(message)
        {
        }
    }
}
