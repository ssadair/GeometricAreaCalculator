using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricAreaCalculatorLibrary
{
    public interface ITriangle :IGeometricFigure
    {





        bool Trianlge_is_rigth_angle(double Leg_a, double Leg_b, double hypotenuse);
        double Calculate_Area(double Leg_a, double Leg_b, double hypotenuse);
      

       

        
    }
}
