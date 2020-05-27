using System;
using System.Collections.Generic;
using System.Text;

namespace laboratorna_14
{
    class TParalelogram : TQuadrangle
    {
        public override double Area(double side_Paral_1, double height)
        {
            return base.Area(side_Paral_1, height);
        }
        public override double Perum(double side_Paral_1, double side_Paral_2)
        {
            return base.Perum(side_Paral_1, side_Paral_2);
        }
    }
}