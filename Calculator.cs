using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    class Calculator
    {
        public void Run()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите команду а затем аргументы. Пример: sum 35 6,9 -4");
                    string[] strArgs = Console.ReadLine().Replace('.', ',').Split(' ');
                    string name = strArgs[0];//первый элемент в массиве - операция
                    double[] args = new double[strArgs.Length - 1];
                    for (int i = 1, j = 0; i < strArgs.Length; i++, j++)//в источнике начинаем смотреть с первого элемента, а заполняем с нулевого
                    {
                        args[j] = Convert.ToDouble(strArgs[i]);
                    }
                 
                    //создаем экземпляр фабрики
                    OperationFactory factory = new OperationFactory();
                    double result = factory.CreateOperation(name).Execute(args);
                    Console.WriteLine(result);
                }
                catch (KeyNotFoundException)
                {
                    Console.WriteLine("Операция не распознана! Для просмотра списка доступных операций, наберите list");
                } 
                catch (ArgCountException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception)
                {
                    Console.WriteLine("Ошибка. Операция не может принимать строковые параметры!");
                }
                Console.WriteLine("Нажмите ENTER для продолжения или ESCAPE для выхода...");
                Console.ReadKey();
            }
        }
    }
}
