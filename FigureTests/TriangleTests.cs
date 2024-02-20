using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureLibrary;
using FigureLibrary.Exceptions;

namespace FigureTests
{
    public class TriangleTests : FigureTests
    {
        [Fact]
        public override void CheckIncorrectArguments()
        {
            Assert.Throws<TriangleException>(() => new Triangle(3, 5, 80));
            Assert.Throws<ArgumentException>(() => new Triangle(-3, 5, 10));
        }

        [Fact]
        public override void EqualsValues()
        {
            Figure triangle = new Triangle(15, 19, 25);
            Assert.Equal(85.46, triangle.Area(), 0.01);
            
            Triangle triangle1 = (Triangle)triangle.Clone();
            triangle1.SideOne = 13;
            Assert.Equal(32.18, triangle1.Area(), 0.01);
        }
    }
}
