using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace laboratorna_15
{
    class TComplex : INum
    {
        double r, i;
        public Complex Sum(Complex A, Complex B)
        {
            r = A.Real + B.Real;
            i = A.Imaginary + B.Imaginary;
            Complex rez = new Complex(r, i);
            return rez;
        }
        public Complex Diference(Complex A, Complex B)
        {
            r = A.Real - B.Real;
            i = A.Imaginary - B.Imaginary;
            Complex rez = new Complex(r, i);
            return rez;
        }
        public Complex Multiplication(Complex A, Complex B)
        {
            r = A.Real * B.Real - A.Imaginary * B.Imaginary;
            i = A.Real * B.Imaginary + B.Real * A.Imaginary;
            Complex rez = new Complex(r, i);
            return rez;
        }
        public Complex Div(Complex A, Complex B)
        {
            double D = B.Real * B.Real + B.Imaginary * B.Imaginary;
            r = (A.Real * B.Real + A.Imaginary * B.Imaginary) / D;
            i = (A.Imaginary * B.Real - A.Real * B.Imaginary) / D;
            Complex rez = new Complex(r, i);
            return rez;
        }

    }
}