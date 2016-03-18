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
                    string name = strArgs[0];//первый элемент в массиве - операция
                    double[] intArgs = new double[strArgs.Length];
                    for (int i = 1; i < strArgs.Length; i++)
                    {
                        intArgs[i] = Convert.ToDouble(strArgs[i]);
                    }
                    switch (name)
                    {
                        case "sum":
                            SumOperation Sum = new SumOperation();
                            Sum.Result(intArgs);
                            break;
                        case "mult":
                            MultOperation Mult = new MultOperation();
                            Mult.Result(intArgs);
                            break;
                        case "div":
                            DivOperation Div = new DivOperation();
                            Div.Result(intArgs);
                            break;
                        case "sub":
                            SubOperation Sub = new SubOperation();
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
