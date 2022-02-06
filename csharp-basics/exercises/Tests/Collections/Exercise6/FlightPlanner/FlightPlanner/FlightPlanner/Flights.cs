using System;
using System.Collections.Generic;
using System.Linq;
using FlightPlanner.Exception;
using static System.Console;

namespace FlightPlanner
{
    public class Flights : IFlights
    {
        public Dictionary<string, string> GetNextFlight(string[] flights)
        {
            if (flights.Length < 2) throw new FlightDoesntHaveDestinationException();

            var routes = new Dictionary<string, string>();

            foreach (var route in flights)
            {
                var citiesFromString = route.Split('-');
                var cityToAdd = citiesFromString[0].Trim();
                var destinationToAdd = citiesFromString[1].Trim();

                if (routes.ContainsKey(cityToAdd))
                    routes[cityToAdd] += destinationToAdd;
                else
                    routes.Add(cityToAdd, destinationToAdd);
            }

            foreach (var route in routes) WriteLine($"{route.Key}{route.Value}");

            return routes;
        }

        public string ShowFlightsFrom(Dictionary<string, string> routes)
        {
            return routes.Aggregate(String.Empty, (current, element) => current + ("Flight from: " + element.Key + " \n"));
        }

        public string ShowFlightsFromAndTo(Dictionary<string, string> flightDictionary)
        {
            return flightDictionary.Aggregate(String.Empty, (current, element) => current + ("Flight from: " + element.Key + " Destination: " + element.Value + "\n"));
        }
    }
}
