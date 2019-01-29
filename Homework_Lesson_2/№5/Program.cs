using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    /// <summary>
    /// Кудинов Даниил
    /// 
    /// а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает,
    /// нужно ли человеку похудеть, набрать вес или все в норме;
    /// б) * Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Ваш рост (см):");
            double h = (double.Parse(Console.ReadLine()) / 100);
            Console.WriteLine("Введите Ваш вес (кг):");
            double m = double.Parse(Console.ReadLine());

            double I = Index(h, m);

            Console.WriteLine($"Индекс массы Вашего тела равен {I:f2}");
            Correction(h, I);
            Console.ReadLine();
        }

        /// <summary>
        /// a) Этот метод вычисляет индекс массы тела
        /// </summary>
        /// <param name="h"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        private static double Index(double h, double m)
        {
            return m / (h * h);
        }

        /// <summary>
        /// б) Этот метод вычисляет необходимость коррекции веса
        /// </summary>
        /// <param name="h">рост</param>
        /// <param name="I">индекс массы</param>
        private static void Correction(double h, double I)
        {
            const double Imin = 18.5;
            const double Imax = 24.99;

            if (I < Imin)
            {
                Console.WriteLine($"Необходимо набрать {(Imin - I) * h * h:f2} кг.");
            }
            else if (I > Imax)
            {
                Console.WriteLine($"Необходимо похудеть на {(I - Imax) * h * h:f2} кг.");
            }
            else
            {
                Console.WriteLine("Ваш вес в пределах нормы");
            }
        }               
    }
}
