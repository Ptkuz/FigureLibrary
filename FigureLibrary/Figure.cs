namespace FigureLibrary
{
    public abstract class Figure : IPrototype
    {
        public abstract double Area();

        public abstract Figure Clone();
    }
}
