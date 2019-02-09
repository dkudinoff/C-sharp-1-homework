using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///Кудинов Даниил
///
///Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2
///по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2).
///Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);

namespace _3_a_
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Введите координату X1:");
            float X1 = (float.Parse(Console.ReadLine()));
            Console.WriteLine("Введите координату Y1:");
            float Y1 = (float.Parse(Console.ReadLine()));
            Console.WriteLine("Введите координату X2:");
            float X2 = (float.Parse(Console.ReadLine()));
            Console.WriteLine("Введите координату Y1:");
            float Y2 = (float.Parse(Console.ReadLine()));

            float r = (float)Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));

            Console.WriteLine($"Расстояние между координатами равно {r:f2}");
            Console.ReadLine();
        }
    }
}
