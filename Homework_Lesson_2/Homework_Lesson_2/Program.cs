using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Lesson_2
{
    /// <summary>
    /// Кудинов Даниил
    /// 
    /// Написать метод, возвращающий минимальное из трех чисел.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите третье число:");
            double c = double.Parse(Console.ReadLine());
          
            Console.WriteLine($"Вы ввели числа: {a}, {b}, {c}.");
            Console.WriteLine($"Наименьшее число: {LargestOfThree(a, b, c)}.");

            Console.ReadLine();
        }

        /// <summary>
        /// Этод метод возвращает наибольшее из трех чисел
        /// </summary>
        /// <param name="a">Первое число</param>
        /// <param name="b">Второе число</param>
        /// <param name="c">Третье число</param>
        /// <returns>Наименьшее из чисел</returns>
        private static double LargestOfThree(double a, double b, double c)
        {
            double result = a < b ?
                (a < c ? a : c)
                :
                (b < c ? b : c);
            return (result);
        }
    }
}
