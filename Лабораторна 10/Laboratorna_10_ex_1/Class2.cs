using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorna_10_ex_1
{
    class Class2
    {
        public double Progress(double a, double b, int c)
        {
            return a + b * (c - 1);
        }
        public double Sumprogres(double a, double b, int c)
        {
            return ((2 * a + b * (c - 1)) / 2) * c;
        }
    }
}