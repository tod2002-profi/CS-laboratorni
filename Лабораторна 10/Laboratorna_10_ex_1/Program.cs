
using System;

namespace Laboratorna_10_ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть перше число прогресії: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введіть різницю: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введіть число яке потрібно знайти: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Class2 result = new Class2();
            Console.WriteLine($"Find {c} of progresion = {result.Progress(a, b, c)}");
            Console.WriteLine($"Find sum = {result.Sumprogres(a, b, c)}");
        }
    }
}
