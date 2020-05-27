using System;
using System.Collections.Generic;
using System.Text;

namespace laboratorna_14
{
    class TRectangle : TQuadrangle
    {
        public override double Area(double side_Rect_1, double side_Rect_2)
        {
            return base.Area(side_Rect_1, side_Rect_2);
        }
        public override double Perum(double side_Rect_1, double side_Rect_2)
        {
            return base.Perum(side_Rect_1, side_Rect_2);
        }
    }
}
