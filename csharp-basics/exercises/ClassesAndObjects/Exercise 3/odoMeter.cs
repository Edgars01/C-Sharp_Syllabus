namespace Exercise_3
{
    public class Odometer
    {
        public Odometer(FuelGauge fuelGauge)
        {
            _fuelGauge = fuelGauge;
        }

        private readonly FuelGauge _fuelGauge;
        private int _currentMileage;

        public int Report()
        {
            return _currentMileage;
        }

        public void Increment()
        {
            if (_fuelGauge.ReportLevel() <= 0) return;

            if (_currentMileage == 999999)
            {
                _currentMileage = 0;
            }
            _currentMileage++;

            if (_currentMileage % 10 == 0)
            {
                _fuelGauge.DecreaseLevel();
            }
        }
    }
}
