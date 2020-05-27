using System;
using System.Numerics;

namespace laboratorna_15
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, y1, x2, y2, a, b, c, d;
            Console.Write("Enter first real complex num: ");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter first imaginary complex num: ");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second real complex num: ");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second imaginary complex num: ");
            y2 = Convert.ToDouble(Console.ReadLine());
            Complex c1 = new Complex(x1, y1);
            Complex c2 = new Complex(x2, y2);
            Console.Write("Enter first numerator: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter first denominator: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second numerator: ");
            c = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second denominator: ");
            d = Convert.ToDouble(Console.ReadLine());
            Complex t1 = new Complex(a, b);
            Complex t2 = new Complex(c, d);
            TComplex tcompl = new TComplex();
            Console.WriteLine($"Suma complex: {tcompl.Sum(c1, c2).Real}+{tcompl.Sum(c1, c2).Imaginary}i");
            Console.WriteLine($"Difirence complex: {tcompl.Diference(c1, c2).Real}+({tcompl.Diference(c1, c2).Imaginary})i");
            Console.WriteLine($"Mult complex: {tcompl.Multiplication(c1, c2).Real}+{tcompl.Multiplication(c1, c2).Imaginary}i");
            Console.WriteLine($"Div complex:{tcompl.Div(c1, c2).Real}+{tcompl.Div(c1, c2).Imaginary}i");
            TRational rat = new TRational();
            Console.WriteLine($"Suma rational: {rat.Sum(t1, t2).Real}/{rat.Sum(t1, t2).Imaginary}");
            Console.WriteLine($"Diference ratinal:{rat.Diference(t1, t2).Real}/{rat.Diference(t1, t2).Imaginary}");
            Console.WriteLine($"Mult rational: {rat.Multiplication(t1, t2).Real}/{rat.Multiplication(t1, t2).Imaginary}");
            Console.WriteLine($"Div rational: {rat.Div(t1, t2).Real}/{rat.Div(t1, t2).Imaginary}");
        }
    }
}