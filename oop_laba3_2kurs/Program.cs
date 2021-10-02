using System;

namespace oop_laba3_2kurs
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            int a;
            float i;
            double c;
            bool l;
            string name;

            //enter var's
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            Console.Write("Enter a(int): ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter i(float): ");
            i = Convert.ToSingle(Console.ReadLine());
            Console.Write("Enter c(double): ");
            c = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter l(bool): ");
            l = Convert.ToBoolean(Console.ReadLine());

            //formating
            Console.WriteLine("Formating result: \n name = {0, 6}, l = {1, 4}", name, l);
            Console.WriteLine("a = {0, 4}, i = {1, 10:f5}, c = {2, 20:e8}", a, i, c);
            Console.WriteLine();
        }
    }
}
