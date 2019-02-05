using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1__2
{
    class Program
    {
        /// <summary>
        /// Кудинов Даниил
        /// 
        /// 1.
        /// Дан  целочисленный  массив  из 20 элементов. 
        /// Элементы  массива  могут принимать  целые  значения  от –10 000 до 10 000 включительно.
        /// Заполнить случайными числами.  Написать программу, позволяющую найти и вывести
        /// количество пар элементов массива, в которых только одно число делится на 3.
        /// В данной задаче под парой подразумевается два подряд идущих элемента массива.
        /// Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2.        
        /// 2.
        /// Реализуйте задачу 1 в виде статического класса StaticClass;
        /// a) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
        /// б) *Добавьте статический метод для считывания массива из текстового файла.
        /// Метод должен возвращать массив целых чисел;
        /// в)**Добавьте обработку ситуации отсутствия файла на диске.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string path = @"E:\Array.txt";
            int[] arr = new int [20];

            ArraySearch.RandomizeArray(ref arr);
            for (int i = 0; i < arr.Length; i++) Console.Write("{0} ", arr[i]);
            Console.WriteLine();
            Console.WriteLine(ArraySearch.Search(arr));

            Array.Clear(arr, 0, arr.Length);

            ArraySearch.ReadFile(out arr, path);
            for (int i = 0; i < arr.Length; i++) Console.Write("{0} ", arr[i]);
            Console.WriteLine();
            Console.WriteLine(ArraySearch.Search(arr));

            Console.ReadLine();

        }
    }
}
