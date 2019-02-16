using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Кудинов Даниил
/// 
/// Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double). 
/// Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).
/// </summary>

public delegate double Fun2(double x, double a);

class Program
{
    public static void Table(Fun2 F, double x, double b, double a)
    {
        Console.WriteLine("---- X --------- Y ----");
        while (x <= b)
        {
            Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x, a));
            x += 1;
        }
        Console.WriteLine("-----------------------");
    }
    public static double MyFunc(double x)
    {
        return x * x * x;
    }
    /// <summary>
    /// Метод 1
    /// </summary>
    /// <param name="x"></param>
    /// <returns></returns>
    public static double MyFunc2(double x, double a)
    {
        return a * x * x;
    }
    /// <summary>
    /// Метод 2 с такой же сигнатурой
    /// </summary>
    /// <param name="x"></param>
    /// <returns></returns>
    public static double MyFunc3(double x, double a)
    {
        return a * Math.Sin(x);
    }

    static void Main()
    {
        Console.WriteLine("Таблица функции a*x^2:");
        Table(MyFunc2, -2, 2, 7);
        Console.WriteLine();
        Console.WriteLine("Таблица функции a*sin(x):");
        Table(MyFunc3, -2, 2, 7);

        Console.ReadLine();
    }
}

