namespace Exercise10.Exceptoon
{
    public class IncorrectAreaOfTriangleException : System.Exception
    {
        public IncorrectAreaOfTriangleException() : base("Invalid parameters provided")
        {
            
        }
    }
}
