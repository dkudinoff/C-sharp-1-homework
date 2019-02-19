using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        /// <summary>
        /// Кудинов Даниил
        /// 
        /// 2. а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке). 
        /// Требуется подсчитать сумму всех нечетных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse;
        /// б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные.
        /// При возникновении ошибки вывести сообщение.Напишите соответствующую функцию;
        /// </summary>
        /// <param name="args"></param>

        /// <summary>
        /// Этот метод проверяет корректность данных
        /// </summary>
        /// <param name="str">введенные данные</param>
        /// <param name="n">число для идентификации</param>
        /// <returns></returns>
        static bool parseInt(string str, out int n)
        {
            return int.TryParse(str, out n);

        }


        static void Main(string[] args)
        {

            int num, sum=0;
            string numbers = "";

            Console.WriteLine("Вводите числа по одному. Чтобы закончить, введите 0");
            do
            {
                if (parseInt(Console.ReadLine(), out num))
                {
                    if (num % 2 == 1)
                    {
                        numbers += num + " ";
                        sum += num;
                    }
                }
                else
                {
                    num = 1;
                    Console.WriteLine($"введены некорректные данные");
                }
            }
            while (num != 0);


            Console.WriteLine($"Подходящие числа: {numbers}");
            Console.WriteLine($"Сумма: {sum}");

            Console.ReadLine();


        }
    }
}
