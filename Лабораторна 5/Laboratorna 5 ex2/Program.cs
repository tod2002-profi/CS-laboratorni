using System;
namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, a, z = 0;
            Console.Write("Введіть число:");
            a = Convert.ToInt32(Console.ReadLine());
            while (a > 0)
            {
                z = a % 10;
                a /= 10;
               x *= 10;
                x += z;
            }
            Console.WriteLine($"Число={x}");

        }
    }
}