using System;
namespace Laboratorna_5_ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 0, b = 1, c = 1, a = 1, x;
            float eps = 0.00001f;
            Console.Write("x=");
            x = Convert.ToInt32(Console.ReadLine());
            while (Math.Abs(a / (b * c)) > eps)
            {
                s += (a / (b * c));
                a *= ((-x) * (-x));
                b *= (c * (c + 1));
                c += 2;
            }
            if (Math.Abs(a / (b * c)) < eps)
                Console.WriteLine($"Suma={s}");//число n     
        }
    }
}