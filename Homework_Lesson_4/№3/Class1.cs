using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class MyArray
    {
        int[] a;
        //  Создание массива и заполнение его одним значением el  
        public MyArray(int n, int el)
        {
            a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = el;
        }
        /// <summary>
        /// Конструктор создает массив заданного размера
        /// и заполняет его числами от начального значения с заданным шагом.
        /// </summary>
        /// <param name="len">размер массива</param>
        /// <param name="s">начальное значение</param>
        /// <param name="step">шаг</param>
        public MyArray(int len, int s, int step)
        {
            a = new int[len];
            for (int i = 0; i < len; i++)
            {
                a[i] = s;
                s += step;
            }
        }
        /// <summary>
        /// Свойство возвращает сумму элементов массива
        /// </summary>
        public int Sum
        {
            get 
            {
                int sum = 0;
                for (int i = 0; i < a.Length; i++) sum+=a[i];
                return sum;
            }
        }
        /// <summary>
        /// Метод, возвращающий новый массив с измененными знаками у всех элементов массива
        /// (старый массив, остается без изменений),
        /// </summary>
        /// <returns>новый массив с измененными знаками</returns>
        public int[] Inverse()
        {
            int[] b = new int[a.Length];
            for (int i = 0; i < a.Length; i++) b[i]=(-a[i]);
            return b;
        }
        /// <summary>
        /// Метод умножает все элементы массива на заданное число
        /// </summary>
        /// <param name="n">заданное число (множитель)</param>
        public void Multi(int n)
        {
            for (int i = 0; i < a.Length; i++) a[i]*=n;
        }
        /// <summary>
        /// Свойство возвращает кол-во максимальных значений в массиве
        /// </summary>
        public int MaxCount
        {
            get
            {
                int maxCount = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i]==Max)
                    {
                        maxCount++;
                    }
                }
                return maxCount;
            }
        }
        public int Max
        {
            get
            {
                int max = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] > max) max = a[i];
                return max;
            }
        }
        public int Min
        {
            get
            {
                int min = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] < min) min = a[i];
                return min;
            }
        }
        public int CountPositiv
        {
            get
            {
                int count = 0;
                for (int i = 0; i < a.Length; i++)
                    if (a[i] > 0) count++;
                return count;
            }
        }
        public override string ToString()
        {
            string s = "";
            foreach (int v in a)
                s = s + v + " ";
            return s;
        }
    }
}
