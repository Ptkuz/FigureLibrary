namespace FigureLibrary.Exceptions
{
    internal class CircleException : Exception
    {

        internal CircleException(string message)
            : base(message)
        {

        }

        internal CircleException(string message, Exception innerException)
            : base(message, innerException)
        {

        }

    }
}
