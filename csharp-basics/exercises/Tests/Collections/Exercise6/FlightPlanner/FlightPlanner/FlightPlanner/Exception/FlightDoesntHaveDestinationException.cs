namespace FlightPlanner.Exception
{
    public class FlightDoesntHaveDestinationException : System.Exception
    {
        public FlightDoesntHaveDestinationException() : base("Provided flight plan doesn't have destination")
        {

        }
    }
}
