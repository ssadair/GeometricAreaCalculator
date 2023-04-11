using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace GeometricAreaCalculatorLibrary
{
    public class GeometricCalculations: ICircle, ITriangle
    {

        public GeometricCalculations() { }
        //double area;




        #region Circle
        
        ///<summary>
        /// Calculate an circle area based in his radius
        /// </summary>
        /// <param name="radius">The circle radius</param>
        /// <returns>The circle area as double</returns>
        public double Calculate_Area(double radius)
        {

           return Math.PI * Math.Pow(radius, 2.0);
        }

        #endregion


        #region Triangle

        ///<summary>
        /// Calculate an triangle area based in his sides length
        /// </summary>
        /// <param name="side_a">Side one of the triangle</param>
        /// <param name="side_b">Side two of the triangle</param>
        /// <param name="side_c">Side three of the triangle</param>
        /// <returns>The triangle area as double</returns>
        public double Calculate_Area(double side_a, double side_b, double side_c)
        {
           
            double area=0;
            

            List<double> list_of_sides = new List<double>(3)
            {
                side_a,
                side_b,
                side_c
            };

            double a, b, c =0;
            list_of_sides.Sort();

            c = list_of_sides.ElementAt(0);

            b = list_of_sides.ElementAt(1);  

            a = list_of_sides.ElementAt(2);

            
                if (a < (c + b))
                {
                    area = 0.25 * Math.Sqrt((a + (b + c)) * (c - (a - b)) * (c + (a - b)) * (a + (b - c)));
                    return area;
                }
                 else
                    {
                         ArgumentException Side_triangle_exception = new ArgumentException("You have entered a Wrong measure of at least one  side of the triangle,the sum of the lengths of two sides of a triangle must be greater than the remaining side  ");

                         throw Side_triangle_exception;
                    }
                
            
           
            
            
         
            /*
            double s = (side_a + side_b + side_c) / 2;
            return Math.Sqrt(s * (s - side_a) * (s - side_b) * (s - side_c));
            */
        }

        ///<summary>
        /// Return true if the triangle is rigth angle or false if not
        /// </summary>
        /// <param name="side_a">Side one of the triangle</param>
        /// <param name="side_b">Side two of the triangle</param>
        /// <param name="side_c">Side three of the triangle</param>
        /// <returns>Return true or false</returns>
        public bool Trianlge_is_rigth_angle(double side_a, double side_b, double side_c)///Return true if the triangle is rigth angle or false if not
        {
            List<double> list_of_sides = new List<double>(3)
            {
                side_a,
                side_b,
                side_c
            };

            double a, b, c = 0;
            list_of_sides.Sort();

            a = list_of_sides.ElementAt(0);

            b = list_of_sides.ElementAt(1);

            c = list_of_sides.ElementAt(2);
            
            if (Math.Pow(c, 2.0) == Math.Pow(b, 2.0) + Math.Pow(a, 2.0))
            {
                return true;
            }
            else { return false; }
        }
 #endregion


    }
}
