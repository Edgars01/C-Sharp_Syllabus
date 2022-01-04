using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static System.Console;

namespace FlightPlanner
{
    public class Flights
    {
        private const string _path = "../../flights.txt";
        public static List<string> RoundTripFlight = new List<string>();
        public static string[] ReadFileFromPath = File.ReadAllLines(_path);
        public static Dictionary<string, string> PossibleRoutes = GetNextFlight(ReadFileFromPath);

        public static string[][] Array = File.ReadAllLines(_path)
            .Select(x => x.Replace(" -> ", "-").Split('-'))
            .ToArray();

        public static void Main(string[] args)
        {
            TravelOrExit();
            WriteLine("\nWhere you gonna start?");
            var flyTo = UserChoice();
            var flyFrom = flyTo;

            do
            {
                RoundTripFlight.Add(flyTo);
                Write("\nSelect the next city : ");
                WriteLine(PossibleRoutes[flyTo]);
                Write("\nSelect the next city : ");
                var userChoice = UserChoice();
                flyTo = userChoice;
            } while (flyFrom != flyTo);

            WriteLine($"\nroute that was chosen: {string.Join(" then ", RoundTripFlight)} to {flyTo}");
            ReadKey();
        }

        public static Dictionary<string, string> GetNextFlight(string[] flights)
        {
            var routes = new Dictionary<string, string>();
            foreach (var route in flights)
            {
                var citiesFromTxt = route.Split('-');
                var cityToAdd = citiesFromTxt[0].Trim();
                var destinationToAdd = citiesFromTxt[1].Trim();

                if (routes.ContainsKey(cityToAdd))
                    routes[cityToAdd] += destinationToAdd;
                else
                    routes.Add(cityToAdd, destinationToAdd);
            }
            foreach (var route in routes) WriteLine($"\n{route.Key}:{route.Value}");

            return routes;
        }

        private static void TravelOrExit()
        {
            var dictionary = new Dictionary<int, string>();
            while (true)
            {
                WriteLine("\n\n What would you like to do:\n");
                WriteLine(" To display list of the cities press 1");
                WriteLine(" To exit program press #");
                var input = ReadLine();
                switch (input)
                {
                    case "1":
                        DisplayCities(dictionary, Array);
                        break;
                    case "#":
                        WriteLine(" Exiting...");
                        Environment.Exit(0);
                        break;
                    default:
                        WriteLine(" Wrong input, try again!");
                        continue;
                }

                break;
            }
        }

        public static void DisplayCities(Dictionary<int, string> dictionary, string[][] array)
        {
            var cities = new HashSet<string>();
            foreach (var city in array) cities.Add(city[0]);
            var numbersForCase = cities.Count();

            var citiesWithNoDuplicates = new string[cities.Count];
            cities.CopyTo(citiesWithNoDuplicates);

            for (var i = 0; i < citiesWithNoDuplicates.Length; i++) dictionary.Add(i, citiesWithNoDuplicates[i]);
            foreach (var city in dictionary) WriteLine($"{city.Key}:{city.Value}");
        }

        public static string UserChoice()
        {
            var userMadeChoice = "";
            var ChooseCity = Convert.ToInt32(ReadLine());
            switch (ChooseCity)
            {
                case 0:
                    userMadeChoice = "San Jose";
                    break;
                case 1:
                    userMadeChoice = "New York";
                    break;
                case 2:
                    userMadeChoice = "Anchorage";
                    break;
                case 3:
                    userMadeChoice = "Honolulu";
                    break;
                case 4:
                    userMadeChoice = "Denver";
                    break;
                case 5:
                    userMadeChoice = "San Francisco";
                    break;
                default:
                    WriteLine(" Wrong input, try again!");
                    break;
            }

            return userMadeChoice;
        }
    }
}
