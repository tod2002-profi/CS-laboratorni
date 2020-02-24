using System;

namespace laboratorna_4_ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b= ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c = ");
            double c = Convert.ToDouble(Console.ReadLine());
            double m = Math.Max(a, b);
            double n = Math.Min(b, c);

            double q = (m + n * n);
            Console.Write(q);
            Console.ReadKey();
        }
    }
}
