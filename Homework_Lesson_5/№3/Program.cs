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
    /// *Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
    /// Например:
    /// badc являются перестановкой abcd
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "bacdvg34";
            string str2 = "acvdg3b4";
            string str3 = "bbavc4gg";

            Console.WriteLine(TranspositionCheck(str1, str2));
            Console.WriteLine(TranspositionCheck(str1, str3));

            Console.ReadLine();
        }
        /// <summary>
        /// Метод получает 2 строки и вычисляет, является ли одна строка перестановкой другой
        /// </summary>
        /// <param name="str1">первая строка</param>
        /// <param name="str2">вторая строка</param>
        /// <returns>результат проверки</returns>
        static public bool TranspositionCheck(string str1, string str2)
        {
            int checkLength = str1.Length;
            foreach (char ch1 in str1)
            {
                foreach (char ch2 in str2)
                {
                    if (ch1 == ch2)
                    {
                        checkLength--;
                        break;
                    }
                }
            }
            return (checkLength == 0);
        }
    }
}
