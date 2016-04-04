using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    class SumOperation:IOperation
    {
        public double Execute(double[] args)
        {
           double x = args.Sum();
            return x;
        }
    }
}
