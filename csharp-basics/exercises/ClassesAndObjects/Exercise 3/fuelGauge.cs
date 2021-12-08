using System;

namespace Exercise_3
{
    public class FuelGauge
    {
        private int _fuelLevel;
        public int ReportLevel()
        {
            return _fuelLevel;
        }

        public bool CheckLevel()
        {
            bool empty = false;
            if (_fuelLevel < 1)
            {
                empty = true;
                Console.WriteLine("Out of fuel");
            }
            return empty;
        }

        public void Fill()
        {
            if (_fuelLevel < 70)
            {
                _fuelLevel++;
            }
        }

        public void DecreaseLevel()
        {
            if (_fuelLevel > 0)
            {
                _fuelLevel--;
            }
        }
    }
}
