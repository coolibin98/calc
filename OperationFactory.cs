using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    class OperationFactory
    {
        public IOperation CreateOperation(string operationName)
        {
            IDictionary<string, IOperation> _operations = new Dictionary<string, IOperation>();//заполняем справочник
            _operations.Add("sum", new SumOperation());
            _operations.Add("sub", new SubOperation());
            _operations.Add("mult", new MultOperation());
            _operations.Add("div", new DivOperation());
            return _operations[operationName];//возвращаем имя экземпляра операции
        }
    }
}
