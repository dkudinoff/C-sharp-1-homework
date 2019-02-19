using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    /// <summary>
    /// Кудинов Даниил
    /// 
    /// Разработать статический класс Message, содержащий следующие статические методы
    /// для обработки текста:
    /// а) Вывести только те слова сообщения,  которые содержат не более n букв.
    /// б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
    /// в) Найти самое длинное слово сообщения.
    /// г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Разработать следующие статические классы Message, " +
                "\tсодержащий следующие оченьдлинноеслово статические методы для обработки текста:" + 
                "\nа) Вывести только слова сообщения словооченьдлинное,  которые содержат словодлинноеочень не более n букв.";
            string msg = message;
            int n = 6;
            char ch = 'е';
            Console.WriteLine(msg);
            Console.WriteLine();
            Message.WriteMinLength(msg, n);
            Console.WriteLine();
            Message.DelWithLastChar(ref msg, ch);
            Console.WriteLine(msg);
            Console.WriteLine();
            msg = message;
            Console.WriteLine(Message.MaxLength(msg));
            Console.WriteLine(Message.MaxLengthString(msg));
            Console.ReadLine();
        }
    }
}
