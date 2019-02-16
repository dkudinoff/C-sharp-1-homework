using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _1__2
{
    public static class ArraySearch
    {
        /// <summary>
        /// Метод принимает массив и заполняет его случайными числами в диапазоне
        /// </summary>
        /// <param name="a">массив для заполнения</param>
        public static void RandomizeArray(ref int [] a)
        {
            Random rnd = new Random();
            for (int i = 0; i < a.GetLength(0); i++)
            {
                a[i] = rnd.Next(-10000, 10000);
            }
        }
        /// <summary>
        /// Метод принимает массив и заполняет его данными из файла
        /// </summary>
        /// <param name="a">массив для заполнения</param>
        /// <param name="path">путь к файлу</param>
        public static void ReadFile(out int[] a, string path)
        {
            if (!File.Exists(path))
            {
                throw new ArgumentException("Файл с массивом не найден");
            }
            string text = File.ReadAllText(path);
            a = text.Split(' ').Select(n => int.Parse(n)).ToArray();
        }
        /// <summary>
        /// Метод принимает массив и считает в нем количество пар элементов массива,
        /// в которых только одно число делится на 3.
        /// </summary>
        /// <param name="a">массив для поиска пар</param>
        /// <returns>кол-во подходящих пар</returns>
        public static int Search(int[] a)
        {
            bool b1 = (a[0] % 3 == 0);
            bool b2;
            int sum = 0; 
            for (int i = 0; i < a.GetLength(0)-1; i++)
            {
                b2 = (a[i+1] % 3 == 0);
                if (b1!=b2)
                {
                    sum++;
                }
                b1 = b2;
            }
            return sum;
        }

    }
}
