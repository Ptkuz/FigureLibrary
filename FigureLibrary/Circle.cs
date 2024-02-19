using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary
{
    public class Circle : Figure
    {

        public double Radius { get; set; }

        public Circle(double radius) 
        {
            Radius = radius;
        }

        public override double Area()
        {
            var area = Math.PI * Radius * Radius;
            return area;
        }
    }
}
