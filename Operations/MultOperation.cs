using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    class MultOperation:IOperation
    {
        public double Execute(double[] args)
        {
            double x = 1;
            for (int i = 0; i < args.Length; i++)
            {
                x *= args[i];
            }
            return x;
        }
    }
}
