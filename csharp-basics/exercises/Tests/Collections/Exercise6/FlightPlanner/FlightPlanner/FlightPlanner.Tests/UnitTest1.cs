using System.Collections.Generic;
using System.Linq;
using FlightPlanner.Exception;
using NUnit.Framework;

namespace FlightPlanner.Tests
{
    public class Tests
    {
        private IFlights _target;
        
        [SetUp]
        public void Setup()
        {
            _target = new Flights();
        }

        [Test]
        public void GetNextFlight_ActualIsSameAs_Expected()
        {
            //Arrange
            string[] flights = { "WawAlKabir -> Zawliyah", "WawAlKabir -> Yakutsk", "PuertoMapuyo -> Ntabazinduna" };
            //Act
            var expected = new Dictionary<string, string>()
            {
                {"WawAlKabir", "> Zawliyah> Yakutsk"},
                {"PuertoMapuyo", "> Ntabazinduna"}
            };

            var actual = _target.GetNextFlight(flights);
            //Assert
            Assert.IsTrue(actual.All(i => expected.Contains(i)));
        }

        [Test]
        public void GetNextFlight_NoFlights_ShouldFail()
        {
            //Arrange
            string[] fail = {"failed"};
            //Assert
            Assert.Throws<FlightDoesntHaveDestinationException>(() => _target.GetNextFlight(fail));
        }

        [Test]
        public void ShowFlightsFrom_ShouldFlyFromWawAlKabirToPuertoMapuyo()
        {
            //Arrange
            var dictionary = new Dictionary<string, string>()
            {
                {"WawAlKabir", "Zawliyah,Yakutsk"},
                {"PuertoMapuyo", "Ntabazinduna"}
            };
            //Act
            var expected = "Flight from: WawAlKabir \nFlight from: PuertoMapuyo \n";
            var actual = _target.ShowFlightsFrom(dictionary);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ShowFlightsFrom_ShouldFlyFromWawAlKabirToNtabazinduna()
        {
            //Arrange
            var dictionary = new Dictionary<string, string>()
            {
                {"WawAlKabir", "Zawliyah,Yakutsk"},
                {"PuertoMapuyo", "Ntabazinduna"}
            };
            //Act
            var expected = "Flight from: WawAlKabir Destination: Zawliyah,Yakutsk\n" +
                           "Flight from: PuertoMapuyo Destination: Ntabazinduna\n";
            var actual = _target.ShowFlightsFromAndTo(dictionary);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}