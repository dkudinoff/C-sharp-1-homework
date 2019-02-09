using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    using System;
    /// <summary>
    /// Кудинов Даниил
    ///
    ///1. а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.
    ///Продемонстрировать работу структуры;
    ///   </summary>
    struct Complex
    {
        public double im;
        public double re;
        /// <summary>
        /// Этот метод вычитает комплексные числа
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public Complex Minus(Complex x)
        {
            Complex y;
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        }
        //  в C# в структурах могут храниться также действия над данными
        public Complex Plus(Complex x)
        {
            Complex y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }
        //  Пример произведения двух комплексных чисел
        public Complex Multi(Complex x)
        {
            Complex y;
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }
        /// <summary>
        /// Вывод результата вычислений в виде строки 
        /// (отдельно для случаев с положительной и отрицательной мнимой частью)
        /// </summary>
        /// <returns></returns>
        public string ToString()
        {
            if (im > 0)
            {
                return re + "+" + im + "i";
            }
            else
            {
                return re + "" + im + "i";
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex complex1;
            complex1.re = 6;
            complex1.im = 1;

            Complex complex2;
            complex2.re = 2;
            complex2.im = 2;

            Complex result = complex1.Plus(complex2);
            Console.WriteLine(result.ToString());
            result = complex1.Multi(complex2);
            Console.WriteLine(result.ToString());
            ///Вывод результата вычитания комплексных чисел
            result = complex1.Minus(complex2);
            Console.WriteLine(result.ToString());
            Console.ReadLine();
        }
    }

}

