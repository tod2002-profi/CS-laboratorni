using System;

namespace Laboratorna_13_ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, num, rebro;

            Console.Write("a= ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("b= ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Сторона a іншого трикутника = ");
            c = Convert.ToDouble(Console.ReadLine());

            Console.Write("Сторона b іншого трикутника = ");
            d = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введіть число = ");
            num = Convert.ToDouble(Console.ReadLine());

            Console.Write("Довжина ребра піраміди = ");
            rebro = Convert.ToDouble(Console.ReadLine());

            TPTriangle t = new TPTriangle(a, b);
            Console.WriteLine($"Площа: {t.Square()}");
            Console.WriteLine($"Периметр: {t.Perumeter()}");
            t.IsEqual(c, d);
            Console.WriteLine("а+в =: {0}", a + b);
            Console.WriteLine("а-в =: {0}", a - b);
            Console.WriteLine("Множення: {0}, {1}", a * num, b * num);
            TPPiramid p = new TPPiramid(rebro);
            Console.WriteLine($"Volume= {p.Volume()}");

        }
    }
}
