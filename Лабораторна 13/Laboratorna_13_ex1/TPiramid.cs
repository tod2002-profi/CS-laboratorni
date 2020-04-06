using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorna_13_ex_1
{
    class TPPiramid : TPTriangle
    {
        double rebro;
        public double Redro
        {
            get
            {
                return rebro;
            }
            set
            {
                if (value > 0) rebro = value;
                else
                    throw new Exception("Lenght of side must be positive value");
            }
        }
        public TPPiramid(double rebro)
        {
            this.rebro = rebro;
        }
        public double Volume()
        {
            return Math.Round(Square() * rebro, 2);
        }
    }
}
