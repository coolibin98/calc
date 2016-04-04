using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    interface IOperation
    {
        double Execute(double[] args);
    }
}
