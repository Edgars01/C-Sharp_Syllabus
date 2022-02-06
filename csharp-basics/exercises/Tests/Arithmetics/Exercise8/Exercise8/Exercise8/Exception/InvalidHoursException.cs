namespace Exercise8.Exception
{
    public class InvalidHoursException : System.Exception
    {
        public InvalidHoursException() : base("Invalid number of hours provided")
        {
            
        }
    }
}
