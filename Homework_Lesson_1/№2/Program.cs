using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///Кудинов Даниил
///
/// Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h);
/// где m — масса тела в килограммах, h — рост в метрах


namespace Homework_Lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Ваш рост (см):");
            double h = (double.Parse(Console.ReadLine()) / 100);
            Console.WriteLine("Введите Ваш вес (кг):");
            double m = double.Parse(Console.ReadLine());

            double I = m / (h * h);

            Console.WriteLine($"Индекс массы Вашего тела равен {I:f2}");
            Console.ReadLine();
        }
    }
}

