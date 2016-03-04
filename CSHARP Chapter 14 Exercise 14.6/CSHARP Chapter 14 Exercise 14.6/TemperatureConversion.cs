using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSHARP_Chapter_14_Exercise_14._6
{
    public partial class TemperatureConversion : Form
    {
        string output;
        double Fahrenheit;
        double Celsius;
        public TemperatureConversion()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            Fahrenheit = Convert.ToDouble(txtFahrenheit.Text);
            Celsius = CalculateCelsius(Fahrenheit);
            output = string.Format("{0:F2} degrees", Celsius);
            lblCelsiusOutput.Text = output;
        }

        private double CalculateCelsius(double fah)
        {
            double calcresult;
            calcresult = 5/9.0 * (Fahrenheit - 32);
            return calcresult;
        }
    }
}
