
using System;
using System.Collections.Generic;
using System.Linq;
namespace Laboratorna_7_ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m;
            Console.Write("Кільсть рядкiв: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Кількість стоапцiв: ");
            m = Convert.ToInt32(Console.ReadLine());
            int[,] A = new int[n, m];
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("A[{0},{1}]= ", i, j);
                    A[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if ((i + j) % 2 == 1 && A[i, j] > 0)
                        sum += A[i, j];
                }
            }

            Console.WriteLine($"Сума додатнiх не парних ел: {sum}");
        }
    }
}