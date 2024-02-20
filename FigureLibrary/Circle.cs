using FigureLibrary.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary
{
    public class Circle : Figure
    {

        private double radius;

        public double Radius 
        {
            get { return radius; }
            set 
            {
                if (value <= 0) 
                {
                    throw new ArgumentException("Радиус круга должен быть больше 0", nameof(Radius));    
                }

                radius = value; 
            }
        }

        public Circle(double radius) 
        {
            Radius = radius;
        }

        public override Figure Clone()
        {
            return new Circle(Radius);
        }

        public override double Area()
        {
            var area = Math.PI * Radius * Radius;
            return area;
        }
    }
}
