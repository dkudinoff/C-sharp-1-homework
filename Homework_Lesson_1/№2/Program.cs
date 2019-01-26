using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Ввести вес и рост человека.
            ///Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h);
            ///где m — масса тела в килограммах, h — рост в метрах

            Console.WriteLine("Введите Ваш рост (см):");
            double h = (double.Parse(Console.ReadLine())/100);
            Console.WriteLine("Введите Ваш вес (кг):");
            double m = double.Parse(Console.ReadLine());

            double I = (double)m / (h * h);

            Console.WriteLine($"Ваш индекс массы равен {I:0.000}");
            Console.ReadLine();
        }
    }
}
