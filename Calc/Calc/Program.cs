using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Calc
    {
        static void Main()
        {
            start://ссылка для повтора
            try
            {
                Console.WriteLine("Введите команду а затем аргументы. Пример: sum 35 6,9 -4");
                string[] strArgs = Console.ReadLine().Replace('.', ',').Split(' ');//создаем массив строк из данных введенных в консоль через пробел. Сплитуем по пробелу. Если в дробное значение с точкой,то меняем точку на запятую
                                                                                   //Console.WriteLine(strArgs.Length);
                double[] intArgs = new double[strArgs.Length];//создаем массив чисел с таким-же размером как у массива строк
                for (int i = 1; i < strArgs.Length; i++)//перебираем каждый элемент стокового массива начиная со второго элемента (т.к. первый это название операции)
                {

                    intArgs[i] = Convert.ToDouble(strArgs[i]);//каждому элементу числового массива, присваиваем значение элемента из строкового массива, предварительно преобразовав стоковое значение в числовое
                }

                if (intArgs.Length < 3)// проверяем чтобы в массиве было как минимум 3 элемента. 1-ый операция и 2 аргуента
                {
                    Console.WriteLine("Команда не распознана. Для выполнения операции необходимо минимум 2 аргумента. Пример: sum 2 2");
                }
                else
                {
                    switch (strArgs[0])// смотрим на первый элемент и ищем совпадения
                    {
                        case "sum":
                            Console.WriteLine("sum = " + intArgs.Sum());//просто вызываем стандартный метод суммирования элементов массива
                            break;
                        case "mult":
                            double mult = 1;//пришлось задать 1 т.к. оставлять пустую переменную не разрешено...
                            for (int i = 1; i < intArgs.Length; i++)
                            {
                                mult *= intArgs[i];
                                Console.WriteLine(intArgs[i]);
                            }
                            Console.WriteLine("mult = " + mult);
                            break;
                        case "div":
                            if (intArgs.Length > 3)
                            {
                                Console.WriteLine("Для операции div возможно использовать только 2 аргумента. Пример: div 7,09 7");
                                break;
                            }
                            else
                            {
                                double div = intArgs[2];
                                div = intArgs[1] / div;
                                Console.WriteLine("div = " + div);
                                break;
                            }

                        case "sub":
                            if (intArgs.Length > 3)
                            {
                                Console.WriteLine("Для операции sub возможно использовать только 2 аргумента. Пример: sub 4,99 2");
                                break;
                            }
                            else
                            {
                                double sub = intArgs[2];
                                sub = intArgs[1] - sub;
                                Console.WriteLine("sub = " + sub);
                                break;
                            }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Нажмите ENTER для продолжения");
                Console.ReadKey();
            }
            goto start;//возвращаемся в начало
        }
    }
}
