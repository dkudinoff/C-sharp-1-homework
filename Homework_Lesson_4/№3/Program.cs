using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    /// <summary>
    /// Кудинов Даниил
    /// 
    /// а) Дописать класс для работы с одномерным массивом.
    /// Реализовать конструктор, создающий массив определенного размера
    /// и заполняющий массив числами от начального значения с заданным шагом.
    /// Создать свойство Sum, которое возвращает сумму элементов массива,
    /// метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива
    /// (старый массив, остается без изменений), 
    /// метод Multi, умножающий каждый элемент массива на определённое число,
    /// свойство MaxCount, возвращающее количество максимальных элементов. 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            MyArray a = new MyArray(10, 0, 100);
            Console.WriteLine(a.ToString());
            Console.WriteLine(a.Max);
            Console.WriteLine(a.Min);
            Console.WriteLine(a.CountPositiv);
            Console.WriteLine();
            Console.WriteLine();

            ///Демонстрация задания
            Console.WriteLine(a.Sum);
            int[] b = a.Inverse();
            for (int i = 0; i < b.Length; i++) Console.Write("{0} ", b[i]);
            Console.WriteLine();
            int n = 4;
            a.Multi(n);
            Console.WriteLine(a.ToString());
            Console.WriteLine(a.MaxCount);
            
            Console.ReadLine();
        }
    }
}
