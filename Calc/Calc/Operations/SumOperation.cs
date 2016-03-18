using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    public class SumOperation: Operation
    {
        public override string Name
        {
            get
            {
                return Name = "sum";
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
                return ArgCount = 10;//здесь должно быть сколько угодно, а не 10
            }

            set
            {
                base.ArgCount = value;
            }
        }
        public override void Result(double[] Args)
        {
            base.Result(Args);
            Console.WriteLine(Args.Sum());
        }
    }
}
