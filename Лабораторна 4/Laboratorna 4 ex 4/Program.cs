using System;

namespace Laboratorna_4_ex_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x = ");
            double x = Convert.ToDouble(Console.ReadLine());
            if ((x <= 0) && (x < 5)) 
                {
                Console.WriteLine("y=1");
            }
            if ((x <= 5) && (x < 8)) 
                {
                Console.WriteLine("y=2");
            }
            if (x < 0)
                {
                Console.WriteLine("y=3");
            }
            if (x >= 8)
                {
                Console.WriteLine("y=4");
            }

        }
    }
}
