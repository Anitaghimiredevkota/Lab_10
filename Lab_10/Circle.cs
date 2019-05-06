using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace Lab_10
{
    class Circle
    {
        private double _radius;//property

        public double Radius
        {
            //set
            //{
            //    _radius = value;
            //}
            get
            {
                return _radius;
            }
        }

        public Circle(double radius)
        {
            _radius = radius;
        }
        public double CalculateCircumference()
        {
            double cir = 2 * Math.PI * Radius;
            return cir;
        }

        public string CalculateFormattedCircumference()
        {
            return CalculateCircumference().ToString("00.00",
                  CultureInfo.InvariantCulture);

        }
        public double CalculatedArea()
        {
            return Math.PI * Radius * Radius;

        }
        public string CalculateFormattedArea()
        {
            return CalculatedArea().ToString("00.00",
                  CultureInfo.InvariantCulture);
        }
        private string FormatNumber(double x)
        {
            return x.ToString("0.00");
        }

    }
}
