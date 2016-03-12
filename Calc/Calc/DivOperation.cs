using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    public class DivOperation : Operation
    {
        public override string Name
        {
            get
            {
                return Name = "div";
            }

            set
            {
                base.Name = value;
            }
        }
        public override int ArgCount
        {
            get
            {
                return ArgCount = 2;
            }

            set
            {
                base.ArgCount = value;
            }
        }
        public override void Result(double[] Args)
        {
            base.Result(Args);
            double div = Args[2];
            div = Args[1] / div;
            Console.WriteLine(div);
        }
    }
}
