using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace laboratorna_15
{
    class TRational : INum
    {
        double r, i;
        public Complex Sum(Complex A, Complex B)
        {
            r = (B.Imaginary * A.Real + A.Imaginary * B.Real);
            i = A.Imaginary * B.Imaginary;
            Complex rez = new Complex(r, i);
            return rez;
        }
        public Complex Diference(Complex A, Complex B)
        {
            r = (B.Imaginary * A.Real - A.Imaginary * B.Real);
            i = A.Imaginary * B.Imaginary;
            Complex rez = new Complex(r, i);
            return rez;
        }
        public Complex Multiplication(Complex A, Complex B)
        {
            r = A.Real * B.Real;
            i = A.Imaginary * B.Imaginary;
            Complex rez = new Complex(r, i);
            return rez;
        }
        public Complex Div(Complex A, Complex B)
        {
            r = A.Real * B.Imaginary;
            i = B.Real * A.Imaginary;
            Complex rez = new Complex(r, i);
            return rez;
        }
    }
}