using System;

namespace laboratorna_14
{
    class Program
    {
        static void Main(string[] args)
        {
            double side_Rect_1, side_Rect_2, side_Sq_1, side_Sq_2, side_Paral_1, side_Paral_2, height, rez = 0, sum;
            Console.Write("Enter side_1 of Rectangle: ");
            side_Rect_1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter side_2 of Rectangle: ");
            side_Rect_2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter side_1 of Square: ");
            side_Sq_1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter side_2 of Square: ");
            side_Sq_2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter side_1 of Paralelogram: ");
            side_Paral_1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter side_2 of Paralelogram: ");
            side_Paral_2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter height of Paralelogram: ");
            height = Convert.ToDouble(Console.ReadLine());
            TRectangle rect = new TRectangle();
            TSquare sq = new TSquare();
            TParalelogram paral = new TParalelogram();
            Random rand = new Random();
            int n = rand.Next(0, 10);
            for (int i = 0; i < n; i++)
            {
                sum = rect.Area(side_Rect_1, side_Rect_2) + sq.Area(side_Sq_1, side_Sq_2) + paral.Perum(side_Paral_1, side_Paral_2);
                rez += sum;
            }
            Console.WriteLine($"Кількістьсть разiв:{n} - Результат:{rez}");
        }
    }
}