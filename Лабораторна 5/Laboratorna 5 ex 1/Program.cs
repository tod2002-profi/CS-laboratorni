using System;
namespace Laboratorna_5_ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double x, a = 0;
            Console.Write("n=");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                x = Math.Pow(2 * i, 2) + Math.Pow(2 * i + 1, 3);
                a += x;
            }
            Console.WriteLine($"s={a}");

        }
    }
}
