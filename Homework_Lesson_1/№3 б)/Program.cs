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
///
///б) Выполните предыдущее задание, оформив вычисления расстояния между точками в виде метода;

namespace _3_б_
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

            Console.WriteLine($"Расстояние между координатами равно {R(X1, X2, Y1, Y2):f2}");
            Console.ReadLine();
        }


        static float R(float X1, float X2, float Y1, float Y2)
        {
            float r = (float)Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
            return (r);
        }
    }
}
