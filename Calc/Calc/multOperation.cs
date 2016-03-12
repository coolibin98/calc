using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    public class MultOperation: Operation
    {
        public override string Name
        {
            get
            {
                return Name = "mult";
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
            double mult = 1;//пришлось задать 1 т.к. оставлять пустую переменную не разрешено...
            for (int i = 1; i < Args.Length; i++)
            {
                mult *= Args[i];
            }
            Console.WriteLine(mult);
        }
    }
}
