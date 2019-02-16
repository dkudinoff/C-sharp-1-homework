using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/// <summary>
/// Кудинов Даниил
/// 
/// 2. Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата. 
/// а) Сделать меню с различными функциями и представить пользователю выбор,
/// для какой функции и на каком отрезке находить минимум. 
/// Использовать массив(или список) делегатов, в котором хранятся различные функции.
/// б) * Переделать функцию Load, чтобы она возвращала массив считанных значений.
/// Пусть она возвращает минимум через параметр(с использованием модификатора out). 
/// </summary>

namespace DoubleBinary
{
    public delegate double Fun(double x);

    class Program
    {
        /// <summary>
        /// Список методов
        /// </summary>
        public static double F0(double x)
        {
            return x * x - 50 * x + 10;
        }
        public static double F1(double x)
        {
            return x * x;
        }
        public static double F2(double x)
        {
            return x * x * x;
        }
        public static double F3(double x)
        {
            return Math.Sin(x);
        }
        public static double F4(double x)
        {
            return Math.Tan(x);
        }
        public static void SaveFunc( Fun F, string fileName, double a, double b, double h)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(F(x));
                x += h;// x=x+h;
            }
            bw.Close();
            fs.Close();
        }
        /// <summary>
        /// В метод Load добавлен параметр min для минимального значения
        /// Метод теперь возвращает массив всех значений
        /// </summary>
        public static double[] Load(string fileName, out double min)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            min = double.MaxValue;
            double d;
            double[] Numbers = new double[fs.Length / sizeof(double)];
            for (int i = 0; i < Numbers.Length; i++)
            {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                Numbers[i] = d;
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return Numbers;
        }
        static void Main(string[] args)
        {
            ///Массив делегатов
            Fun[] delsArr = new Fun[5];
            delsArr[0] = new Fun(F0);
            delsArr[1] = new Fun(F1);
            delsArr[2] = new Fun(F2);
            delsArr[3] = new Fun(F3);
            delsArr[4] = new Fun(F4);
            double Min;
            
            int i;
            double a, b, step;
            ///Выбор функции
            Console.WriteLine("Выберите функцию, введя ее номер:");
            Console.WriteLine("1. x * x - 50 * x + 10");
            Console.WriteLine("2. x * x");
            Console.WriteLine("3. x * x * x");
            Console.WriteLine("4. Sin(x)");
            Console.WriteLine("5. Tan(x)");
            i = Int32.Parse(Console.ReadLine());       
            while (i < 1 || i > 5)
            {
                ///Обработка некорректного введенного значения
                Console.WriteLine("Такой функции нет. Повторите ввод.");
                i = Int32.Parse(Console.ReadLine());
            }
            i--;
            Console.WriteLine("Введите нижнюю границу отрезка:");
            a = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введите верхнюю границу отрезка:");
            b = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введите шаг:");
            step = Double.Parse(Console.ReadLine());

            SaveFunc(delsArr[i], "data.bin", a, b, step);
            double[] Numbers = Load("data.bin", out Min);
            foreach (double item in Numbers)
            {
                Console.Write($"{item:f3}   ");
            }
            Console.WriteLine();
            Console.WriteLine($"Минимальное значение:{Min}");

            Console.ReadKey();
        }
    }
}

