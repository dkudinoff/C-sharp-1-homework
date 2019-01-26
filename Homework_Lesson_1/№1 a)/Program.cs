using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///Кудинов Даниил
///
/// Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес).
/// В результате вся информация выводится в одну строчку.
/// а) используя склеивание;

namespace Homework_Lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Ваше имя:");
            string name = Console.ReadLine();
            Console.WriteLine("Введите Вашу фамилию:");
            string surname = Console.ReadLine();
            Console.WriteLine("Введите Ваш возраст:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите Ваш рост (см):");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите Ваш вес (кг):");
            int weight = int.Parse(Console.ReadLine());

            Console.WriteLine(name + " " + surname + " " + age + " " + height + " " + weight);
            Console.ReadLine();
        }
    }
}
