using System;
using System.Collections.Generic;
using System.Linq;
namespace Laboratorna_6_ex_2
{
    class Program
    {
        static int Factorial(int x)
        {
            if (x == 0)
                return 1;
            else
                return x * Factorial(x - 1);
        }
        static void Main(string[] args)
        {
            Console.Write("Введіть  b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введіть  i: ");
            int i = Convert.ToInt32(Console.ReadLine());
            List<double> arr = new List<double>();
            List<double> arr_1 = new List<double>();
            double sum = 0;
            for (int e = 1; e <= i; e++)
            {
                sum += Math.Round(Factorial(e) * Math.Sin(e * b), 4);
                arr.Add(sum);
            }
            foreach (double el in arr)
            {
                Console.Write(el + " ");
            }

        }


    }
}
