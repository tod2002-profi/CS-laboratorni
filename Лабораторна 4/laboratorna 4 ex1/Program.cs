using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
                Console.Write("d = ");
                double d = Convert.ToDouble(Console.ReadLine());

            double a = d / Math.Sqrt(2);
            double s = a *  a;
            double p = a * 4;
            Console.Write(s);
            Console.Write(p);
                Console.ReadKey();
            
        }
    }
}
