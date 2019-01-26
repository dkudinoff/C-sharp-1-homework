using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_б_
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Даниил Кудинов Санкт-Петербург";
            Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.WindowHeight / 2);
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
