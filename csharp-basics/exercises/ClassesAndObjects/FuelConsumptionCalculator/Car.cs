using System;

namespace FuelConsumptionCalculator
{
    public class Car
    {
        private double _startKilometers;
        private double _liters;

        public Car(double startOdo)
        {
            _startKilometers = startOdo;
        }

        public double CalculateConsumption()
        {
            return Math.Round(this._liters / this._startKilometers * 100, 2);
        }

        private double ConsumptionPer100Km()
        {
            return 0;
        }

        public bool GasHog()
        {
            return ConsumptionPer100Km() > 15;
        }

        public bool EconomyCar()
        {
            return ConsumptionPer100Km() < 5;
        }

        public void FillUp(int mileage, double liters)
        {
            _startKilometers += mileage;
            _liters += liters;
        }
    }
}
