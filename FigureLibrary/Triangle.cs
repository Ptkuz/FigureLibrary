using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary
{
    public class Triangle : Figure
    {
        public double SideOne {  get; set; }

        public double SideTwo { get; set; } 

        public double SideThree { get; set; }

        public Triangle(double sideOne, double sideTwo, double sideThree) 
        { 
            SideOne = sideOne;
            SideTwo = sideTwo;
            SideThree = sideThree;
        }

        private double GetPerimeter() 
        {
            var perimeter = SideOne + SideOne + SideThree;
            return perimeter;
        }

        private double GetHalfPerimeter() 
        {
            var halfPerimeter = GetPerimeter() / 2;
            return halfPerimeter;
        }

        public bool CheckVersatile()
        {
            var check = SideOne * SideOne + SideTwo * SideTwo == SideThree * SideThree;
            return check;
        }

        public override double Area()
        {
            var halfPerimeter = GetHalfPerimeter();
            var area = Math.Sqrt(halfPerimeter * (halfPerimeter - SideOne) * (halfPerimeter - SideTwo) * (halfPerimeter - SideThree));
            return area;
        }
    }
}
