using System;
using System.Collections.Generic;

namespace Laboratorna_7_ex_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m;
            Console.Write("Кількість рядкiв: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Кількість стовцiв: ");
            m = Convert.ToInt32(Console.ReadLine());
            int[,] A = new int[n, m];
            int[] Vect = new int[m];
            List<int> Answer = new List<int>();
            int k = -1, sum = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("A[{0},{1}]= ", i, j);
                    A[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < m; i++)
            {
                Console.Write($"Введіть вектор:{i}= ");
                Vect[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < m; i++)
            {
                k++;
                if (k == m)
                    break;
                for (int j = 0; j < n; j++)
                {
                    sum += Vect[k] * A[i, j];
                    Answer.Add(sum);
                    sum = 0;
                }
            }
            for (int i = 0; i < Answer.Count; i++)
            {
                Console.WriteLine($"Новий вектор = {Answer[i]}");
            }
        }
    }
}