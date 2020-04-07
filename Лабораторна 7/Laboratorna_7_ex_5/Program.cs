using System;

namespace Laboratorna_7_ex_5
{
    class Program
    {
        static int Neg(int[] vect)
        {
            int result = 0;
            for (int i = 0; i < vect.Length; i++)
            {
                if (vect[i] < 0)
                    result += 1;
            }
            return result;
        }
        static void Main(string[] args)
        {
            int n, m;
            Console.Write("Кількість рядкiв: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Кількість стовпцiв: ");
            m = Convert.ToInt32(Console.ReadLine());
            int[,] A = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("A[{0},{1}]= ", i, j);
                    A[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            int[] collumn = new int[m];
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    collumn[j] = A[j, i];
                }
                if (Neg(collumn) > 0)
                    Console.WriteLine($"Сума стовпця № {i + 1}: {sum += collumn[i]}");
            }

        }
    }
}

