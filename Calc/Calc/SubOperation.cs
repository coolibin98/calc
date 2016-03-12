using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    public class SubOperation : Operation
        {
            public override string Name
            {
                get
                {
                    return Name = "sub";
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
                double sub = Args[2];
                sub = Args[1] - sub;
                Console.WriteLine(sub);
            }
        }
    }

