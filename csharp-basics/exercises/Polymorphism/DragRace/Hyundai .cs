using System;
using System.Collections.Generic;
using System.Text;

namespace DragRace
{
    internal class Hyundai : ICar
    {
        private int _currentSpeed = 0;
        private string _name = "hyundai";

        public string GetName()
        {
            return _name;
        }

        public string ShowCurrentSpeed()
        {
            return _currentSpeed.ToString();
        }

        public void SlowDown()
        {
            _currentSpeed -= 6;
        }

        public void SpeedUp()
        {
            _currentSpeed += 6;
        }

        public void StartEngine()
        {
            Console.WriteLine(" hyundai onomatopoeia - vivIIiiiiiiiiiiBRbbBrbbbRbbrrtBst");
        }
    }
}
