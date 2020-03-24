using System;
using System.Collections.Generic;
using System.Linq;
namespace Laboratorna_6_ex_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть len: ");
            int len = int.Parse(Console.ReadLine());
            int[] array = new int[len];
            for (int i = 0; i < len; i++)
            {
                Console.Write($"Введіть елем вектора-{i}:");
                array[i] = int.Parse(Console.ReadLine());
            }
            int[] array_1 = new int[len];
            for(int k=0; k<len;k++){
                 Console.Write($"Введіть елем вектора1-{k}:");
                 array_1[k] = int.Parse(Console.ReadLine());}
             for (int j=0;j<len;j++){
                 if(j!=len-1){
                     if (array[j]/array_1[j]!=array[j+1]/array_1[j+1])
                         Console.WriteLine("Вектори не паралельні!");
                         break;}
                 else
                     Console.WriteLine("Вектори паралельні!");}
        }
    }
}