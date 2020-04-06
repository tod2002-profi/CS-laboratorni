using System;

namespace Laboratorna_10_ex_2
{
    class Class1
    {
        string name;
        int bithday;
        int date;
        int course;
        int[] rating;
        int scholarship;

        public Class1(string name, int bithday, int date, int course, int[] rating, int scholarship)
        {
            this.name = name;
            this.bithday = bithday;
            this.date = date;
            this.course = course;
            this.rating = rating;
            this.scholarship = scholarship;
        }
        public double Averenge(int sum)
        {
            double result = sum / rating.Length;
            return Math.Round(result);
        }
        public int Age()
        {
            DateTime moment = new DateTime();
            int year = moment.Year;
            return year - bithday;
        }
        public int End(int a)
        {
            return date + (4 - a);
        }
    }
}
