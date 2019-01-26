using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// Кудинов Даниил
/// 
///Написать программу обмена значениями двух переменных.
///а) с использованием третьей переменной;

namespace _4_a_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите переменную a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите переменную b:");
            int b = int.Parse(Console.ReadLine());
            int c;

            c = a;
            a = b;
            b = c;

            Console.WriteLine($"a = {a}, b = {b}");
            Console.ReadLine();
        }
    }
}
