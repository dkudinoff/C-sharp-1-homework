using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    /// <summary>
    /// Кудинов Даниил
    /// 
    /// Реализовать метод проверки логина и пароля. На вход подается логин и пароль.
    /// На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).
    /// Используя метод проверки логина и пароля, написать программу:
    /// пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
    /// С помощью цикла do while ограничить ввод пароля тремя попытками.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string login, password;
            int i = 3;

            Console.WriteLine("Введите логин: ");
            login = Console.ReadLine();
            Console.WriteLine("Введите пароль: ");
            password = Console.ReadLine();
            while (!Authorization.AuthCheck(login, password))
            {
                i--;
                if (i == 0)
                {
                    Console.WriteLine("Превышен лимит попыток. Доступ ограничен.");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                Console.WriteLine("Неверные данные пользователя. Попробуйте еще раз");
                Console.WriteLine($"Осталось попыток: {i}");
                Console.WriteLine("Введите логин: ");
                login = Console.ReadLine();
                Console.WriteLine("Введите пароль: ");
                password = Console.ReadLine();
            }
            Console.WriteLine($"Добро пожаловать, {login}!");
            Console.ReadLine();      
        }
    }
}
