using System;

namespace Laboratorna_12_ex_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] xn = new double[3];
            double[] yn = new double[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Введіть x{0}: ", i + 1);
                xn[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введіть y{0}: ", i + 1);
                yn[i] = Convert.ToInt32(Console.ReadLine());
            }
            TTriangle tr = new TTriangle(xn, yn);
            Console.WriteLine("a = {0}, b ={1}, c = {2}", tr.a(), tr.b(), tr.c());
            Console.WriteLine("Площа: {0}" + "\n" + "Периметр: {1}", tr.Square(), tr.Perum());
        }
    }
}
