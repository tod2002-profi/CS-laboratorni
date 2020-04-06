using System;

namespace Laboratorna_8_ex_3
{
    class Program
    {
        static int Recur(int a)
        {
            if (a == 0)
                return 0;
            else if (a == 1)
                return 9;
            else
                return 2 * Recur(a - 1) + 3 * Recur(a - 2);
        }
        static void Main(string[] args)
        {
            Console.Write("Введіть n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int recur = Recur(n);
            Console.WriteLine($"Xn = {recur}");
        }
    }
}