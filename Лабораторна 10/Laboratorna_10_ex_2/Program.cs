using System;

namespace Laboratorna_10_ex_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter name: ");
            string name = Convert.ToString(Console.ReadLine());
            Console.Write("Enter birthday(year): ");
            int birhday = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter year of introducation: ");
            int date = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter course: ");
            int course = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter scholarship: ");
            int scholarship = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter len subject: ");
            int len = Convert.ToInt32(Console.ReadLine());
            string[] subject = new string[len];
            int[] rating = new int[len];

            for (int i = 0; i < len; i++)
            {
                Console.Write($"Enter subject-{i + 1}: ");
                subject[i] = Convert.ToString(Console.ReadLine());
            }
            int suma = 0, s;

            for (int i = 0; i < len; i++)
            {
                Console.Write($"Enter rating for {subject[i]}:  ");
                s = Convert.ToInt32(Console.ReadLine());
                rating[i] = s;
                suma += s;
            }
            Class1 stud = new Class1(name, birhday, date, course, rating, scholarship);
            Console.WriteLine($"Averenge rat: {stud.Averenge(suma)}");

            for (int i = 0; i < rating.Length; i++)
            {
                if (rating[i] < stud.Averenge(suma))
                    Console.WriteLine(subject[i] + ":" + rating[i]);
            }
            Console.WriteLine($"Age: {stud.Age()}");
            Console.WriteLine($"Year when end: {stud.End(course)}");
        }
    }
}