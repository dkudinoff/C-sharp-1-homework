using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    static public class Message
    {
        /// <summary>
        /// Метод возвращает только те слова сообщения,  которые содержат не более n букв.
        /// </summary>
        /// <param name="str">строка</param>
        /// <param name="n">максимум букв в слове</param>
        static public void WriteMinLength(string str, int n)
        {
            string[] split = str.Split(new Char[] { ' ', ',', '.', ':', ';', '!', '?', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string s in split)
            {
                if (s.Length<=n)
                    Console.Write(s + " ");
            }
            Console.WriteLine();
        }
        /// <summary>
        /// Метод удаляет из сообщения все слова, которые заканчиваются на заданный символ.
        /// </summary>
        /// <param name="str">строка</param>
        /// <param name="ch">заданный символ</param>
        static public void DelWithLastChar(ref string str, char ch)
        {
            string[] split = str.Split(new Char[] { ' ', ',', '.', ':', ';', '!', '?', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string s in split)
            {
                int n;
                if (s[s.Length-1]==ch)
                {
                    n = str.IndexOf(s);
                    if (n != 0)
                        str = str.Remove(n-1, s.Length+1);
                    else
                        str = str.Remove(n, s.Length);
                }
            }
        }
        /// <summary>
        /// Метод находит самое длинное слово сообщения.
        /// </summary>
        /// <param name="str">строка</param>
        /// <returns>самое длинное слово</returns>
        static public string MaxLength(string str)
        {
            string[] split = str.Split(new Char[] { ' ', ',', '.', ':', ';', '!', '?', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            int n = 0;
            string sMax = "";
            foreach (string s in split)
            {
                if (s.Length > n)
                {
                    n = s.Length;
                    sMax = s;
                }       
            }
            return sMax;
        }
        /// <summary>
        /// метод формирует строку с помощью StringBuilder из самых длинных слов сообщения.
        /// </summary>
        /// <param name="str">строка</param>
        /// <returns>новая строка из самых длинных слов</returns>
        static public StringBuilder MaxLengthString(string str)
        {
            int max = MaxLength(str).Length;
            string[] split = str.Split(new Char[] { ' ', ',', '.', ':', ';', '!', '?', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder maxString = new StringBuilder("");
            foreach (string s in split)
            {
                if (s.Length == max)
                    maxString.Append(s + " ");
            }
            return maxString;
        }       
    }
}
