using System;

namespace Laboratorna_12_ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double r1, r2, num;
            Console.Write("Ведіть радіус 1: ");
            r1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введіть радіус 2: ");
            r2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введіть число: ");
            num = Convert.ToDouble(Console.ReadLine());
            TCirle tcirle = new TCirle(r1, r2);
            Console.WriteLine("Area: {0}", tcirle.Area());
            Console.WriteLine("Len circle: {0}", tcirle.Len());
            Console.WriteLine("r1>r2: {0}", tcirle.Diff());
            Console.WriteLine("Додавання: {0}", r1 + r2);
            Console.WriteLine("Віднімання: {0}", r1 - r2);
            Console.WriteLine("Множення: {0}", r1 * num);
        }
    }
}
