using System.Collections.Generic;

namespace FlightPlanner
{
    public interface IFlights
    {
        public Dictionary<string, string> GetNextFlight(string[] flights);

        public string ShowFlightsFrom(Dictionary<string, string> routes);

        public string ShowFlightsFromAndTo(Dictionary<string, string> routes);
    }
}