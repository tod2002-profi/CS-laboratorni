using System;
using System.Collections.Generic;
using System.Text;

namespace laboratorna_14
{
    class TSquare : TRectangle
    {
        public double Area_Rect(double side_Sq_1, double side_Sq_2)
        {
            return base.Area(side_Sq_1, side_Sq_2);
        }
        public double Perum_Rect(double side_Sq_1, double side_Sq_2)
        {
            return base.Perum(side_Sq_1, side_Sq_2);
        }
    }
}

