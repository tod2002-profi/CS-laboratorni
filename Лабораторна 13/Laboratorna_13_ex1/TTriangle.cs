using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorna_13_ex_1
{
    class TPTriangle
    {
        double a;
        double b;
        double hypoten;
        public double A
        {
            get
            {
                return a;
            }
            set
            {
                if (value > 0) a = value;
                else
                    throw new Exception("Lenght of side must be positive value");
            }
        }
        public double B
        {
            get
            {
                return b;
            }
            set
            {
                if (value > 0) b = value;
                else
                    throw new Exception("Lenght of side must be positive value");
            }
        }
        public TPTriangle(double a, double b)
        {
            A = a;
            B = b;
        }
        public TPTriangle(double a)
        {
            A = a;
            B = a;
        }
        public TPTriangle()
        {
            A = 3;
            B = 4;
        }
        public TPTriangle(TPTriangle t)
        {
            A = t.A;
            B = t.B;
        }
        public double Square()
        {
            return (a * b) * 0.5;
        }
        public double Perumeter()
        {
            hypoten = Math.Sqrt(A * A + B * B);
            return Math.Round(A + B + hypoten, 2);
        }
        public void IsEqual(double a, double b)
        {
            if (A == a && B == b)
            {
                Console.WriteLine("Triangles are equal");
            }
            else if (A == a && B > b || A > a && B == b || A > a && B > b)
            {
                Console.WriteLine("First triangle is bigger");
            }
            else
                Console.WriteLine("Second triangle is bigger");
        }
        public static double operator +(TPTriangle t)
        {
            return t.A + t.B;
        }
        public static double operator -(TPTriangle t)
        {
            return Math.Abs(t.A - t.B);
        }
        public static TPTriangle operator *(TPTriangle t, double n)
        {
            return new TPTriangle(t.A * n, t.B * n);
        }

    }
}
