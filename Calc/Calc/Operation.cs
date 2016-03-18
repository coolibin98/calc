using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    public class Operation
    {
        public virtual string Name { get; set; }//Имя операции
        public virtual int ArgCount { get; set; }//Количество принимаемых аргуентов     
        public virtual void Result(double[] Args)
        {
            if (Args.Length-1 > ArgCount)
            {
                Console.WriteLine("Для операции " + Name + " возможно использовать только " + ArgCount + " аргумента(ов). Пример: " + Name + " 4,99 2");
            }
            Console.WriteLine(Name + "= ");
        }
      
    }
}
