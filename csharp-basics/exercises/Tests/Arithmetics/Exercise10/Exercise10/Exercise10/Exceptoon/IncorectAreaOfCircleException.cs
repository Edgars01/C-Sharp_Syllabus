namespace Exercise10
{
    public class IncorrectAreaOfCircleException : System.Exception
    {
        public IncorrectAreaOfCircleException() : base("Area of circle cant be smaller than one")
        {

        }
    }
}
