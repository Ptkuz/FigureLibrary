using FigureLibrary.Exceptions;
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

        private double sideOne;
        public double SideOne 
        {
            get 
            {
                return sideOne;
            }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Сторона треугольника должена быть больше 0", nameof(SideOne));
                }

                sideOne = value;
            }
        }


        private double sideTwo;
        public double SideTwo
        {
            get
            {
                return sideTwo;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Сторона треугольника должена быть больше 0", nameof(SideTwo));
                }

                sideTwo = value;
            }
        }

        private double sideThree;

        public double SideThree
        {
            get
            {
                return sideThree;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Сторона треугольника должена быть больше 0", nameof(SideThree));
                }
                sideThree = value;
            }
        }

        public Triangle(double sideOne, double sideTwo, double sideThree) 
        { 
            SideOne = sideOne;
            SideTwo = sideTwo;
            SideThree = sideThree;

            if (!CheckExists())
            {
                throw new TriangleException($"Треугольника со сторонами \"{SideOne}\" \"{SideTwo}\" \"{SideThree}\" не существует!");
            }
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

        private bool CheckExists() 
        {
            return 
            SideOne + SideTwo > SideThree
            && SideOne + SideThree > SideTwo
            && SideTwo + SideThree > SideOne;
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

        public override Figure Clone()
        {
            return new Triangle(SideOne, SideTwo, SideThree);
        }
    }
}
