using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometricAreaCalculatorLibrary;
using System.Data;

namespace GeometricCalculationsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(10,10,10)]
        [DataRow(15,10,10)]
        [DataRow(10,15,10)]
        [DataRow(10,10,15)]
        [DataRow(22.5,17.5,37.8)]
        public void Test_TriangleAreaCalculation_Measure_of_side_correct(double a, double b, double c)
        {
            double triangle_area;

            

            GeometricCalculations geometricCalculations = new GeometricCalculations();

            //Calculate possible scenarios of values of the sides of a triangle
            //Validating that is possible to form a triangle with the values provided 
            for (int i = 0; i < 5; i++)
            {
                triangle_area = geometricCalculations.Calculate_Area(a,b,c);

                Assert.IsTrue(triangle_area >0);
                

            }


           

           
        }

        [TestMethod]
        [DataRow(10, 10, 10,43.301)]
        [DataRow(15, 10, 10,49.608)]
        [DataRow(10, 15, 10,49.608)]
        [DataRow(10, 10, 15,49.608)]
        [DataRow(22.5, 17.5, 37.8,122.546)]
        public void Test_TriangleAreaCalculation_Correct_Result_Values(double a, double b, double c, double result)
        {
            double triangle_area;



            GeometricCalculations geometricCalculations = new GeometricCalculations();

            //Calculate possible scenarios of values of the sides of a triangle
            //Validating that is possible to form a triangle with the values provided 
            for (int i = 0; i < 5; i++)
            {
                triangle_area = geometricCalculations.Calculate_Area(a, b, c);

                Assert.IsTrue(Math.Round(triangle_area,3) == result);


            }





        }

        [TestMethod]
        [DataRow(10, 10, 21)]
        [DataRow(15, 10, 26)]
        [DataRow(30, 15, 10)]
        [DataRow(10, 45, 15)]
        [DataRow(22.5, 17.5, 49.8)]
        public void Test_TriangleAreaCalculation_Is_Not_a_Triangle(double a, double b, double c)
        {
            



            GeometricCalculations geometricCalculations = new GeometricCalculations();

            //Calculate possible scenarios of wrong values of a triangle
            //Validating that is not possible to form a triangle with the values provided 
            for (int i = 0; i < 5; i++)
            {
                
                
                
               
                Assert.ThrowsException<ArgumentException> (() => geometricCalculations.Calculate_Area(a, b, c));


            }





        }

        [TestMethod]
        [DataRow(10,314.16)]
        [DataRow(1,3.14)]
        [DataRow(15.34,739.27)]
        public void TestCircleAreaCalculation(double a, double result)
        {
            double circle_area;
            GeometricCalculations geometricCalculations = new GeometricCalculations();

            for (int i = 0; i < 5; i++)
            {
                circle_area = geometricCalculations.Calculate_Area(a);

                Assert.IsTrue(Math.Round(circle_area, 2) == result);


            }
        }

        [TestMethod]
        [DataRow(5, 3, 4)]
        [DataRow(12, 13, 5)]
        [DataRow(6, 8, 10)]
        public void TestIsRigthAngle_True(double a, double b , double c)
        {

            bool triangle_is_rigth;



            GeometricCalculations geometricCalculations = new GeometricCalculations();

            //Calculate possible scenarios of values of the sides of a triangle
            //Validating that is a rigth triangle
            for (int i = 0; i < 5; i++)
            {
                triangle_is_rigth = geometricCalculations.Trianlge_is_rigth_angle(a, b, c);

                Assert.IsTrue(triangle_is_rigth);


            }
        }

        [TestMethod]
        [DataRow(25.3, 3, 4)]
        [DataRow(12, 35, 5)]
        [DataRow(6, 8, 3.4)]
        public void TestIsRigthAngle_False(double a, double b, double c)
        {

            bool triangle_is_rigth;



            GeometricCalculations geometricCalculations = new GeometricCalculations();

            //Calculate possible scenarios of values of the sides of a triangle
            //Validating that is not a rigth triangle 
            for (int i = 0; i < 5; i++)
            {
                triangle_is_rigth = geometricCalculations.Trianlge_is_rigth_angle(a, b, c);

                Assert.IsFalse(triangle_is_rigth);


            }
        }
    }
}