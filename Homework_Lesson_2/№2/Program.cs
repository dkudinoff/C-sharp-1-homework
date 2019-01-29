using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    /// <summary>
    /// Кудинов Даниил
    /// 
    /// Написать метод подсчета количества цифр числа.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число:");
            int num = int.Parse(Console.ReadLine());
            

            Console.WriteLine(Count(ref num));

            Console.ReadLine();
        }

        /// <summary>
        /// Этот метод считает кол-во цифр в числе
        /// </summary>
        /// <param name="num">Число</param>
        /// <returns>количество цифр</returns>
        private static int Count(ref int num)
        {
            int i = 0;

            do
            {
                i++;
                num /= 10;
            }
            while (num != 0);

            return (i);
        }
    }
}
