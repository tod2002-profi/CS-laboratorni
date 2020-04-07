using System;

namespace Laboratorna_12_ex_2
{
    class TBankomat
    {
        int a5;
        int a10;
        int a20;
        int a50;
        int a100;
        int a200;
        int sum;
        public TBankomat(int a5, int a10, int a20, int a50, int a100, int a200, int sum)
        {
            this.a5 = a5;
            this.a10 = a10;
            this.a20 = a20;
            this.a50 = a50;
            this.a100 = a100;
            this.a200 = a200;
            this.sum = sum;
        }
        public int Minsum()
        {
            if (a5 > 0) return 5;
            else if (a10 > 0) return 10;
            else if (a20 > 0) return 20;
            else if (a50 > 0) return 50;
            else if (a100 > 0) return 100;
            else if (a200 > 0) return 200;
            else return 0;
        }
        public uint Maxsum()
        {
            uint a = Convert.ToUInt32(5 * a5 + 10 * a10 + 20 * a20 + 50 * a50 + a100 * 100 + 200 * a200);
            return a;
        }
        string s;
        int a = 0;
        public string Amount()
        {
            if (Maxsum() > sum)
            {
                if (sum < 5) return sum.ToString();
                while (sum > 5)
                {
                    if (sum / 200 > 0)
                    {
                        a = sum / 200;
                        sum -= 200 * a;
                        s += "200*" + a;
                    }
                    else if (sum / 100 > 0)
                    {
                        a = sum / 100;
                        sum -= 100 * a;
                        s += "+100*" + a;
                    }
                    else if (sum / 50 > 0)
                    {
                        a = sum / 50;
                        sum -= 50 * a;
                        s += "+50*" + a;
                    }
                    else if (sum / 20 > 0)
                    {
                        a = sum / 20;
                        sum -= 20 * a;
                        s += "+20*" + a;
                    }
                    else if (sum / 10 > 0)
                    {
                        a = sum / 10;
                        sum -= 10 * a;
                        s += "+10*" + a;
                    }
                    else
                    {
                        a = sum / 5;
                        sum -= 5 * a;
                        s += "+5*" + a;
                    }
                }
                return s;
            }
            else
                return "impossible";
        }
    }
}
