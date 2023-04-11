using GeometricAreaCalculatorLibrary;

namespace CalculateGeometricArea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double triangle_area;
            GeometricCalculations geometricCalculations = new GeometricCalculations();
            try
            {
                
                triangle_area = geometricCalculations.Calculate_Area(double.Parse(textBoxLegA.Text), double.Parse(textBox_LegB.Text), double.Parse(textBox_Hypotenuse.Text));
                MessageBox.Show(triangle_area.ToString());
            }
            catch (Exception exceptiona)
            {
                MessageBox.Show(exceptiona.Message); 
                throw;
            }
            /*
            double triangle_area = geometricCalculations.Calculate_Area(double.Parse(textBoxLegA.Text), double.Parse(textBox_LegB.Text), double.Parse(textBox_Hypotenuse.Text));
            MessageBox.Show(triangle_area.ToString());
            */

        }

        private void button2_Click(object sender, EventArgs e)
        {
            GeometricCalculations geometricCalculations = new GeometricCalculations();

            double circle_area = geometricCalculations.Calculate_Area(double.Parse(textBox_Radius.Text));
            MessageBox.Show(circle_area.ToString());
        }
    }
}