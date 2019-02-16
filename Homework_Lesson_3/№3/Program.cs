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
    /// *Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел. 
    /// Предусмотреть методы сложения, вычитания, умножения и деления дробей. 
    /// Написать программу, демонстрирующую все разработанные элементы класса.
    /// ** Добавить проверку, чтобы знаменатель не равнялся 0.
    ///    Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
    /// *** Добавить упрощение дробей.
    /// </summary>

    ///Класс дробей
    class Fraction
    {
        int num, denom;

        /// <summary>
        /// Конструктор создания пустой дроби
        /// </summary>
        public Fraction()
        {
            num = 0;
            denom = 0;
        }

        /// <summary>
        /// Конструктор создания дроби с заданным числителем и знаменателем
        /// </summary>
        /// <param name="num">числитель</param>
        /// <param name="denom">знаменатель</param>
        public Fraction(int num, int denom)
        {
            if (denom == 0)
            {
                throw new ArgumentException("Знаменатель не может быть равен 0");
            }

            this.num = num;
            this.denom = denom;
            ///избавление от лишних минусов 
            if (this.denom<0)
            {
                this.denom *= -1;
                this.num *= -1;
            }
        }
        /// <summary>
        /// Метод суммы дробей
        /// </summary>
        /// <param name="x2">второе слагаемое (дробь)</param>
        /// <returns>сумма (дробь)</returns>
        public Fraction Sum(Fraction x2)
        {
            Fraction x3 = new Fraction();
            int nod = NOD(this.denom, x2.denom);
            int temp1 = this.denom / nod;
            int temp2 = x2.denom / nod;
            x3.denom = (this.denom * temp2);
            x3.num = this.num * temp2 + x2.num * temp1;
            Simplif(x3);
            return x3;
        }
        /// <summary>
        /// Метод вычитания дробей
        /// </summary>
        /// <param name="x2">вычитаемое (дробь)</param>
        /// <returns>разность (дробь)</returns>
        public Fraction Diff(Fraction x2)
        {
            Fraction x3 = new Fraction();
            int nod = NOD(this.denom, x2.denom);
            int temp1 = this.denom / nod;
            int temp2 = x2.denom / nod;
            x3.denom = (this.denom * temp2);
            x3.num = this.num * temp2 - x2.num * temp1;
            Simplif(x3);
            return x3;
        }
        /// <summary>
        /// Метод умножения дробей
        /// </summary>
        /// <param name="x2">второй множитель (дробь)</param>
        /// <returns>произведение (дробь)</returns>
        public Fraction Multi(Fraction x2)
        {
            Fraction x3 = new Fraction();
            x3.denom = this.denom * x2.denom;
            x3.num = this.num * x2.num;
            Simplif(x3);
            return x3;
        }
        /// <summary>
        /// Метод деления дробей
        /// </summary>
        /// <param name="x2">делитель (дробь)</param>
        /// <returns>частное (дробь)</returns>
        public Fraction Div(Fraction x2)
        {
            Fraction x3 = new Fraction();
            x3.denom = this.denom * x2.num;
            x3.num = this.num * x2.denom;
            Simplif(x3);
            return x3;
        }
        /// <summary>
        /// Метод нахождения наибольшего общего делителя (НОД)
        /// Необходим для упрощения дробей.
        /// </summary>
        /// <param name="N1">первое число</param>
        /// <param name="N2">второе число</param>
        /// <returns></returns>
        static public int NOD(int N1, int N2)
        {
            int Nmin = N1 < N2 ? Math.Abs(N1) : Math.Abs(N2);
            int Nmax = Math.Abs(N1) + Math.Abs(N2) - Nmin;

            int nod = 1;
            for (int i = 1; i <= Math.Sqrt(Nmin); i++)
            {
                if (Nmin % i == 0)
                {
                    int quot = Nmin / i;
                    if (Nmax % quot == 0)
                    {
                        nod = quot;
                        break;
                    }
                    else if (Nmax % i == 0)
                    {
                        nod = i;
                    }
                }
            }
            return nod;
        }
        /// <summary>
        /// Метод упрощения финальной дроби
        /// </summary>
        /// <param name="x3">упрощенная дробь</param>
        /// <returns></returns>
        public Fraction Simplif(Fraction x3)
        {
            int nod = NOD(x3.num, x3.denom);
            x3.num /= nod;
            x3.denom /= nod;
            return x3;
        }
        /// <summary>
        /// Метод представления дроби в виде строки
        /// </summary>
        /// <returns></returns>
        public string ToString()
        {            
            return num + "/" + denom;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Fraction x1;
            Fraction x2;
            Fraction result;
            int num, denom;

            while (true)
            {
                Console.Write($"Введите числитель первой дроби: ");
                num = Int32.Parse(Console.ReadLine());
                Console.Write($"Введите числитель первой дроби: ");
                denom = Int32.Parse(Console.ReadLine());
                x1 = new Fraction(num, denom);
                Console.Write($"");
                Console.Write($"Введите числитель второй дроби: ");
                num = Int32.Parse(Console.ReadLine());
                Console.Write($"Введите числитель второй дроби: ");
                denom = Int32.Parse(Console.ReadLine());
                x2 = new Fraction(num, denom);
                result = x1.Sum(x2);
                Console.WriteLine($"Сумма дробей: {result.ToString()}");
                result = x1.Diff(x2);
                Console.WriteLine($"Разность дробей: {result.ToString()}");
                result = x1.Multi(x2);
                Console.WriteLine($"Произведение дробей: {result.ToString()}");
                result = x1.Div(x2);
                Console.WriteLine($"Частное дробей: {result.ToString()}");
                Console.Write($"");

            }

            Console.ReadLine();
        }

    }
}
