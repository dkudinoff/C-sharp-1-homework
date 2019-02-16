using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    /// <summary>
    /// Кудинов Даниил
    /// 
    /// Создать программу, которая будет проверять корректность ввода логина. 
    /// Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита
    /// или цифры, при этом цифра не может быть первой:
    /// а) без использования регулярных выражений;
    /// б) ** с использованием регулярных выражений.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string login;
            bool check = false;

            Console.WriteLine("Введите логин.");
            Console.WriteLine("*Логин должен иметь от 2 до 10 символов.");
            Console.WriteLine("*Логин должен состоять только из латинских букв и цифр.");
            Console.WriteLine("*Первый символ логина не может быть цифрой");

            while (!check)
            {
                login = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("(метод без регулярного выражения)");
                if (Check.NoRegular(login))
                {
                    Console.WriteLine("Логин принят");
                    check = true;
                }
                else
                {
                    Console.WriteLine("Логин не отвечает заданным требованиям. Повторите ввод");
                }
                Console.WriteLine();
                Console.WriteLine("(метод с регулярным выражением)");
                if (Check.Regular(login))
                {
                    Console.WriteLine("Логин принят");
                    check = true;
                }
                else
                {
                    Console.WriteLine("Логин не отвечает заданным требованиям. Повторите ввод");
                }

            }
            Console.ReadLine();
        }     
    }
}
