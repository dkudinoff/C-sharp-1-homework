using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;


class Student
{
    /// <summary>
    /// Кудинов Даниил
    /// 
    /// Переделать программу Пример использования коллекций для решения следующих задач:
    /// а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
    /// б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся(*частотный массив);
    /// в) отсортировать список по возрасту студента;
    /// г) *отсортировать список по курсу и возрасту студента;
    /// </summary>

    public string lastName;
    public string firstName;
    public string university;
    public string faculty;
    public int course;
    public string department;
    public int group;
    public string city;
    public int age;
    // Создаем конструктор
    public Student(string firstName, string lastName, string university, string faculty, string department, int course, int age, int group, string city)
    {
        this.lastName = lastName;
        this.firstName = firstName;
        this.university = university;
        this.faculty = faculty;
        this.department = department;
        this.course = course;
        this.age = age;
        this.group = group;
        this.city = city;
    }
}

class Program
{
    /// <summary>
    /// Метод, для сортировки списка по курсу, а при одинаковом курсе - по возрасту
    /// </summary>
    /// <param name="st1">студент 1</param>
    /// <param name="st2">студент 2</param>
    /// <returns>результат сравнения</returns>
    static int MyDelegat(Student st1, Student st2)
    {
        int a = st1.course.CompareTo(st2.course);
        if (a == 0) return st1.age.CompareTo(st2.age);
        else return a;
    }

    static void Main(string[] args)
    {
        // объявляем частотный массив
        int[,] freq = new int[6,2] { { 1, 0 }, { 2, 0 }, { 3, 0 }, { 4, 0 }, { 5, 0 }, { 6, 0 } };  
        int bakalavr = 0;
        int magistr = 0;
        List<Student> list = new List<Student>();                             // Создаем список студентов
        DateTime dt = DateTime.Now;
        StreamReader sr = new StreamReader("students_6.csv", Encoding.GetEncoding(1251));
        while (!sr.EndOfStream)
        {
            try
            {
                string[] s = sr.ReadLine().Split(';');
                // Добавляем в список новый экземпляр класса Student
                list.Add(new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8]));
                // Создадим временные переменные чтобы не парсить одни данные по нескольку раз.
                int tempAge = int.Parse(s[6]);
                int tempCourse = int.Parse(s[5]);
                // Одновременно подсчитываем количество бакалавров и магистров
                if (tempCourse < 5) bakalavr++; else magistr++;
                // Заполняем частотный массив
                if (tempAge > 17 && tempAge < 21) freq[tempCourse-1, 1]++;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Ошибка!ESC - прекратить выполнение программы");
                // Выход из Main
                if (Console.ReadKey().Key == ConsoleKey.Escape) return;
            }
        }
        sr.Close();
        list.Sort(new Comparison<Student>(MyDelegat));
        Console.WriteLine("Всего студентов:" + list.Count);
        Console.WriteLine("Магистров:{0}", magistr);
        Console.WriteLine("Бакалавров:{0}", bakalavr);
        // студенты на 5-6 курсах - магистры
        Console.WriteLine($"Количество учащихся на 5-6 курсах: {magistr}");
        Console.WriteLine();
        foreach (var v in list) Console.WriteLine(@"{0, 10}   курс: {1}   возраст: {2}", v.firstName, v.course, v.age);
        Console.WriteLine();
        Console.WriteLine("Количество учащихся в возрасте 18-20 лет на разных курсах:");
        // Выводим частотный массив
        for (int i = 0; i < freq.Length; i++)
        {
            Console.WriteLine(@"{0} курс: {1}", freq[i, 0], freq[i, 1]);
        }
        Console.WriteLine(DateTime.Now - dt);
        Console.ReadKey();
    }
}

