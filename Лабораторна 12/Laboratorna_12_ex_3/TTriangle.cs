using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorna_12_ex_3
{
    class TTriangle
    {
        double[] xn;
        double[] yn;
        public TTriangle(double[] xn, double[] yn)
        {
            this.xn = xn;
            this.yn = yn;
        }

        public double a()
        {
            return Math.Sqrt(Math.Pow((xn[1] - xn[0]), 2) + Math.Pow((yn[1] - yn[0]), 2));
        }
        public double b()
        {
            return Math.Sqrt(Math.Pow((xn[2] - xn[1]), 2) + Math.Pow((yn[2] - yn[1]), 2));
        }
        public double c()
        {
            return Math.Sqrt(Math.Pow((xn[2] - xn[0]), 2) + Math.Pow((yn[2] - yn[0]), 2));
        }
        double A, B, C;
        TTriangle(TTriangle t)
        {
            A = t.a();
            B = t.b();
            C = t.c();
        }
        public double Square()
        {
            double p = (A + B + C) / 2;
            return Math.Round(Math.Sqrt(p * (p - A) * (p - B) * (p - C)));
        }
        public double Perum()
        {
            return A + B + C;
        }
    }
}
