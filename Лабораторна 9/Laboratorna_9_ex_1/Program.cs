using System;
using System.Collections.Generic;

namespace Laboratorna_9_ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> basa = new Dictionary<string, string>();
            string[] basadanih = { "Паспортнi данi", "Освiта", "Спецiальнiсть", "Посада", "Оклад" };
            foreach (string el in basadanih)
            {
                Console.Write($"{el} = ");
                basa[el] = Convert.ToString(Console.ReadLine());
            }

            foreach (KeyValuePair<string, string> el in basa)
            {
                Console.WriteLine("Key = {0}, Value = {1}", el.Key, el.Value);
            }
        }
    }
}