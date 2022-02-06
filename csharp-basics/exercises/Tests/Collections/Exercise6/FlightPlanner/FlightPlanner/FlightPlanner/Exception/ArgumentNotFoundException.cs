namespace FlightPlanner.Exception
{
    public class ArgumentNotFoundException : System.Exception
    {
        public ArgumentNotFoundException() : base("Provided string is empty")
        {
            
        }
    }
}
