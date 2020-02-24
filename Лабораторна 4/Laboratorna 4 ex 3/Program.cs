using System;

namespace Laboratorna_4_ex_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x1= ");
            double x1= Convert.ToDouble(Console.ReadLine());
            Console.Write("y1= ");
            double y1= Convert.ToDouble(Console.ReadLine());
            Console.Write("x2= ");
            double x2= Convert.ToDouble(Console.ReadLine());
            Console.Write("y2= ");
            double y2= Convert.ToDouble(Console.ReadLine());
            Console.Write("x3= ");
            double x3= Convert.ToDouble(Console.ReadLine());
            Console.Write("y3= ");
            double y3= Convert.ToDouble(Console.ReadLine());

            double AB = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            double BC = Math.Sqrt((x3 - x2) * (x3 - x2) + (y3 - y2) * (y3 - y2));
            double AC = Math.Sqrt((x3 - x1) * (x3 - x1) + (y3 - y1) * (y3 - y1));
            if ((AB == BC) || (AB == AC))
            {
                Console.WriteLine("Трикутник ABC Рівносторонній");
            }
            else
            {
                Console.WriteLine("Трикутник ABC НЕ Рівносторонній");
            }


        }
    }
}
