namespace Date.Tests.Exception
{
    public class InvalidDateException : System.Exception
    {
        public InvalidDateException() : base("Invalid date parameter provided")
        {
            
        }
    }
}
