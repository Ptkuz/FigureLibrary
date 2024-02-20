using FigureLibrary;

namespace FigureTests
{
    public class CircleTests : FigureTests
    {
        [Fact]
        public override void EqualsValues()
        {
            Figure figure = new Circle(50);
            Assert.Equal(7853.98, figure.Area(), 0.01);
        }

        [Fact]
        public override void CheckIncorrectArguments() 
        {
            Assert.Throws<ArgumentException>(() => new Circle(-3));
            Assert.Throws<ArgumentException>(() => new Circle(0));
        }
    }
}