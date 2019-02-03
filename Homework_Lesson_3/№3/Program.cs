using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{

    class Fraction
    {
        int num, denom;

        public Fraction()
        {
            num = 0;
            denom = 0;
        }

        public Fraction(int num, int denom)
        {
            if (denom == 0)
            {
                throw new ArgumentException("Знаменатель не может быть равен 0");
            }

            this.num = num;
            this.denom = denom;

            if (this.denom<0)
            {
                this.denom = Math.Abs(this.denom);
                this.num *= -1;
            }
        }

        public Fraction Sum(Fraction x2)
        {
            Fraction x3 = new Fraction();
            int nod = NOD(this.denom, x2.denom);
            int temp1 = this.denom / nod;
            int temp2 = x2.denom / nod;
            x3.denom = (this.denom * temp2);
            x3.num = this.num * temp2 + x2.num * temp1;
            Simplif(x3);
            return x3;
        }

        public Fraction Diff(Fraction x2)
        {
            Fraction x3 = new Fraction();
            int nod = NOD(this.denom, x2.denom);
            int temp1 = this.denom / nod;
            int temp2 = x2.denom / nod;
            x3.denom = (this.denom * temp2);
            x3.num = this.num * temp2 - x2.num * temp1;
            Simplif(x3);
            return x3;
        }

        public Fraction Multi(Fraction x2)
        {
            Fraction x3 = new Fraction();
            x3.denom = this.denom * x2.denom;
            x3.num = this.num * x2.num;
            Simplif(x3);
            return x3;
        }

        public Fraction Div(Fraction x2)
        {
            Fraction x3 = new Fraction();
            x3.denom = this.denom * x2.num;
            x3.num = this.num * x2.denom;
            Simplif(x3);
            return x3;
        }



        static public int NOD(int N1, int N2)
        {
            int Nmin = N1 < N2 ? Math.Abs(N1) : Math.Abs(N2);
            int Nmax = Math.Abs(N1) + Math.Abs(N2) - Nmin;

            int nod = 1;
            for (int i = 1; i <= Math.Sqrt(Nmin); i++)
            {
                if (Nmin % i == 0)
                {
                    int quot = Nmin / i;
                    if (Nmax % quot == 0)
                    {
                        nod = quot;
                        break;
                    }
                    else if (Nmax % i == 0)
                    {
                        nod = i;
                    }
                }
            }
            return nod;
        }

        public Fraction Simplif(Fraction x3)
        {
            int nod = NOD(x3.num, x3.denom);
            x3.num /= nod;
            x3.denom /= nod;
            return x3;
        }


        public string ToString()
        {            
            return num + "/" + denom;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Fraction x1;
            Fraction x2;
            Fraction result;
            int num, denom;

            while (true)
            {
                Console.Write($"Введите числитель первой дроби: ");
                num = Int32.Parse(Console.ReadLine());
                Console.Write($"Введите числитель первой дроби: ");
                denom = Int32.Parse(Console.ReadLine());
                x1 = new Fraction(num, denom);
                Console.Write($"");
                Console.Write($"Введите числитель второй дроби: ");
                num = Int32.Parse(Console.ReadLine());
                Console.Write($"Введите числитель второй дроби: ");
                denom = Int32.Parse(Console.ReadLine());
                x2 = new Fraction(num, denom);
                result = x1.Sum(x2);
                Console.WriteLine($"Сумма дробей: {result.ToString()}");
                result = x1.Diff(x2);
                Console.WriteLine($"Разность дробей: {result.ToString()}");
                result = x1.Multi(x2);
                Console.WriteLine($"Произведение дробей: {result.ToString()}");
                result = x1.Div(x2);
                Console.WriteLine($"Частное дробей: {result.ToString()}");
                Console.Write($"");

            }

            Console.ReadLine();
        }

    }
}
