using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Кудинов Даниил
/// 
/// б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса;
/// </summary>
class Complex
{
    // Поля приватные.
    private double im;
    // По умолчанию элементы приватные, поэтому private можно не писать.
    double re;

    // Конструктор без параметров.
    public Complex()
    {
        im = 0;
        re = 0;
    }

    // Конструктор, в котором задаем поля.    
    // Специально создадим параметр re, совпадающий с именем поля в классе.
    public Complex(double _im, double re)
    {
        // Здесь имена не совпадают, и компилятор легко понимает, что чем является.              
        im = _im;
        // Чтобы показать, что к полю нашего класса присваивается параметр,
        // используется ключевое слово this
        // Поле параметр
        this.re = re;
    }
    public Complex Plus(Complex x2)
    {
        Complex x3 = new Complex();
        x3.im = x2.im + im;
        x3.re = x2.re + re;
        return x3;
    }
    /// <summary>
    /// Метод вычитает комплексные числа
    /// </summary>
    /// <param name="x2"></param>
    /// <returns></returns>
    public Complex Minus(Complex x2)
    {
        Complex x3 = new Complex();
        x3.im = this.im - x2.im;
        x3.re = this.re - x2.re;
        return x3;
    }
    /// <summary>
    /// Метод умножает комплексные числа
    /// </summary>
    /// <param name="x2"></param>
    /// <returns></returns>
    public Complex Multi(Complex x2)
    {
        Complex x3 = new Complex();
        x3.im = x2.im + im;
        x3.re = x2.re + re;

        x3.im = this.re * x2.im + this.im * x2.re;
        x3.re = this.re * x2.re - this.im * x2.im;
        return x3;
    }
    // Свойства - это механизм доступа к данным класса.
    public double Im
    {
        get { return im; }
        set
        {
            // Для примера ограничимся только положительными числами.
            if (value >= 0) im = value;
        }
    }
    // Специальный метод, который возвращает строковое представление данных.
    public string ToString()
    {
        if (im > 0)
        {
            return re + "+" + im + "i";
        }
        else
        {
            return re + "" + im + "i";
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Описали ссылку на объект.
        Complex complex1;
        // Создали объект и сохранили ссылку на него в complex1.
        complex1 = new Complex(1, 6);
        // Описали объект и создали его.
        Complex complex2 = new Complex(1, 2);
        // С помощью свойства Im изменили внутреннее (приватное) поле im.
        complex2.Im = 2;
        // Создали ссылку на объект.
        Complex result;
        // Так как в методе Plus создается новый объект,
        // в result сохраняем ссылку на вновь созданный объект.
        result = complex1.Plus(complex2);
        Console.WriteLine(result.ToString());

        ///Вывод результата вычитания
        result = complex1.Minus(complex2);
        Console.WriteLine(result.ToString());
        ///Вывод результата умножения
        result = complex1.Multi(complex2);
        Console.WriteLine(result.ToString());
        Console.ReadLine();
    }
}