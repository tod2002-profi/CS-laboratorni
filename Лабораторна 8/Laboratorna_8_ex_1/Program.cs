using System;

namespace Laboratorna_8_ex_1
{
    class Program
    {
        static int Factorial(int x)
        {
            int c = 1;
            for (int i = 1; i < x; i++)
            {
                c *= i;
            }
            return c;
        }

        static double Func(double x)
        {
            double count = 0;
            if (x < 0)
            {
                count = 1;
                for (int i = 2; i < 9; i++)
                {
                    count += (x / Factorial(i));
                    x *= x;
                }
                return count;
            }
            else if (x >= 0 && x <= 5)
                return 15 + Math.Sqrt(Math.Pow(Math.Cos(x), 6));
            else
                return Math.Min(1, 2 * Math.Sin(x));
        }

        static void Main(string[] args)
        {
            double a, b, u;
            Console.Write("Введіть а: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введіть в: ");
            b = Convert.ToInt32(Console.ReadLine());
            u = Math.Max(Func(a), Func(b)) - Func(3);
            Console.WriteLine($"U={u}");
        }
    }
}
