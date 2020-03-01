using System;
namespace Laboratorna_5_ex4
{
    class Program
    {
        static int Recur(int n)
        {
            if (n == 0)
                return 0;
            else if (n == 1 ^ n == 2)
                return 9;
            return Recur(n - 1) + 4 * Recur(n - 3);
        }
        static void Main(string[] args)
        {
            Console.Write("n=");
            int num = Convert.ToInt32(Console.ReadLine()), num_1 = num;
            num = Recur(num);
            Console.WriteLine("X({0})={1}", num_1, num);
        }
    }
}