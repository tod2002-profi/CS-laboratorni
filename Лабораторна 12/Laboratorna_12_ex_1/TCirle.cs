using System;

namespace Laboratorna_12_ex_1
{
    class TCirle
    {
        public double radius1;
        public double radius2;
        public double R1
        {
            get
            {
                return radius1;
            }
            set
            {
                if (value > 0) radius1 = value;
                else
                    throw new Exception("Lenght of side must be positive value");
            }

        }
        public double R2
        {
            get
            {
                return radius2;
            }
            set
            {
                if (value > 0) radius2 = value;
                else
                    throw new Exception("Lenght of side must be positive value");
            }

        }
        public TCirle()
        {
            radius1 = 5;
            radius2 = 7;
        }
        public TCirle(double radius1, double radius2)
        {
            this.radius1 = radius1;
            this.radius2 = radius2;
        }
        public double Area()
        {
            return 2 * Math.PI * Math.Pow(radius1, 2);
        }
        public double Len()
        {
            return 2 * Math.PI * radius1;
        }
        public bool Diff()
        {
            bool a = false;
            if (radius1 > radius2)
                a = true;
            return a;
        }
        public double Value { get; set; }
        public static TCirle operator +(TCirle radius1, TCirle radius2)
        {

            return new TCirle { Value = radius1.Value + radius2.Value };
        }
        public static TCirle operator -(TCirle radius1, TCirle radius2)
        {

            return new TCirle { Value = radius1.Value - radius2.Value };
        }
        public static TCirle operator *(TCirle radius1, double a)
        {

            return new TCirle { Value = radius1.Value * a };
        }
    }
}