using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    /// <summary>
    /// Кудинов Даниил
    /// 
    /// С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Вводите целые числа по очереди. Чтобы завершить, введите 0");
            Console.WriteLine($"Сумма всех нечетных положительных чисел = {SumPosOdd()}");

            Console.ReadLine();
        }

        /// <summary>
        /// Этот метод вычисляет сумму всех нечетных положительных чисел среди введенных 
        /// </summary>
        /// <returns>сумма нечетных положительных чисел</returns>
        private static long SumPosOdd()
        {
            int num = 0;
            long sum = 0;
            do
            {
                num = int.Parse(Console.ReadLine());
                if (num > 0 && num % 2 != 0)
                {
                    sum += num;
                }
            }
            while (num != 0);
            return sum;
        }
    }
}
