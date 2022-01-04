using System;

namespace DragRace
{
    public class Canno : ICar
    {
        private int _currentSpeed = 0;
        private string _name = "Canno";

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
            _currentSpeed -= 8;
        }

        public void SpeedUp()
        {
            _currentSpeed += 8;
        }

        public void StartEngine()
        {
            Console.WriteLine(" canno onomatopoeia - IiiIIiiIIiiIi");
        }
    }
}
