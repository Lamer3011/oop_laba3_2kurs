using System;
using System.IO;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            double x, y;

            StreamWriter writer = new StreamWriter("D:\\visual studio projects\\oop_laba3_2kurs\\ex2\\laba2.res");
            StreamReader reader = new StreamReader("D:\\visual studio projects\\oop_laba3_2kurs\\ex2\\laba2.txt");

            writer.WriteLine("Отримано: \n");
            metka: s = reader.ReadLine();
            if (s == null) goto metka1;
            x = double.Parse(s);
            y = Math.Pow(Math.Sin(x), 2)/(x - 1);

            writer.WriteLine("x = {0:F3} y = {1:e3} \n ************", x, y);
            goto metka;
            metka1: writer.WriteLine("Створив Сергій Кірєєв {0} \n", s);

            writer.Close();
            reader.Close();

        }
    }
}
