using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    class DivOperation : IOperation
    {
        
        public double Execute(double[] args)
        {
            
                if (args.Length == 2)
                {
                    double x = args[0] / args[1];
                    return x;
                }
                else
                {
                    throw new ArgCountException("Аргументов должно быть 2");
                }
        }
    }
}
