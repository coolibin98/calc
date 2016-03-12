using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    public class Calc
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите команду а затем аргументы. Пример: sum 35 6,9 -4");
                    string[] strArgs = Console.ReadLine().Replace('.', ',').Split(' ');
                    double[] intArgs = new double[strArgs.Length];
                    for (int i = 1; i < strArgs.Length; i++)
                    {

                        intArgs[i] = Convert.ToDouble(strArgs[i]);
                    }
                    SumOperation Sum = new SumOperation();//инициализируем объекты
                    MultOperation Mult = new MultOperation();
                    SubOperation Sub = new SubOperation();
                    DivOperation Div = new DivOperation();
                    switch (strArgs[0])// смотрим на первый элемент и ищем совпадения
                    {

                        case "sum":
                            Sum.Result(intArgs);
                            break;
                        case "mult":
                            Mult.Result(intArgs);
                            break;
                        case "div":
                            Div.Result(intArgs);
                            break;
                        case "sub":
                            Sub.Result(intArgs);
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ошибка: " + ex.Message);
                }

                Console.WriteLine("Нажмите ENTER для продолжения или ESCAPE для выхода");
                while (Console.ReadKey().Key != ConsoleKey.Enter);
            }
        }
    }
        
    }
