using System;
using System.Linq;
using System.Collections.Generic;
// Числа вводити через пробіл
namespace lab_6_ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть Число: ");
            int[] array = Console.ReadLine().Split().Select(i => int.Parse(i)).ToArray();
            
            List<int> min_arr = new List<int>();
            foreach (int el in array)
            {
                if (el >= 0)
                    min_arr.Add(el);
            }
            Console.WriteLine(min_arr.Min());
        }
    }
}

