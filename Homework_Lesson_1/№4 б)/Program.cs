using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// Кудинов Даниил
/// 
///Написать программу обмена значениями двух переменных.
///б) *без использования третьей переменной.

namespace _4_б_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите переменную a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите переменную b:");
            int b = int.Parse(Console.ReadLine());

            a = a ^ b;
            b = b ^ a;
            a = a ^ b;

            Console.WriteLine($"a = {a}, b = {b}");
            Console.ReadLine();
        }
    }
}
