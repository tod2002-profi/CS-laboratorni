using System;
using System.Collections.Generic;

namespace Laboratorna_6_ex_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Кількість елементів: ");
            int len = Convert.ToInt32(Console.ReadLine());
            double[] arr1 = new double[len];
            List<Double> arr2 = new List<double>();
            List<Double> ans = new List<double>();
            for (int i = 0; i < len; i++)
            {
                Console.Write($"Елемент-{i}: ");
                arr1[i] = Convert.ToDouble(Console.ReadLine());
            }
            double nul = 0;
            foreach (double el in arr1)
            {
                if (el != 0)
                    arr2.Add(el);
                else
                    nul++;

            }
            int count = 0;
            while (nul > count)
            {
                ans.Add(0);
                count++;
            }

            for (int l = 0; l < arr2.Count; l++)
                ans.Add(arr2[l]);

            for (int i = 0; i < ans.Count; i++)
                Console.Write($"/{ans[i]}/");
        }
    }
}