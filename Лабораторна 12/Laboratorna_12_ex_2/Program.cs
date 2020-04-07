using System;

namespace Laboratorna_12_ex_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a5, a10, a20, a50, a100, a200, sum;
            Console.Write("Кількість купюр номіналом 5: ");
            a5 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Кількість купюр номіналом  10: ");
            a10 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Кількість купюр номіналом  20: ");
            a20 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Кількість купюр номіналом  50: ");
            a50 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Кількість купюр номіналом  100: ");
            a100 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Кількість купюр номіналом  200: ");
            a200 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введіть суму яку потрібно зняти: ");
            sum = Convert.ToInt32(Console.ReadLine());
            TBankomat bank = new TBankomat(a5, a10, a20, a50, a100, a200, sum);
            Console.WriteLine("Мінімальна сума яку можливо зняти = {0}" + "\n" + "Максимальна сума яку можливо зняти = {1}", bank.Minsum(), bank.Maxsum());
            Console.WriteLine("Номінал та кількість купюр які буде видано  = {0}", bank.Amount());

        }
    }
}
