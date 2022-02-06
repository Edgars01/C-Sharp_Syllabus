using DragRace.Exception;

namespace DragRace
{
    public class Hyundai : ICar
    {
        private int _currentSpeed = 0;
        private string _name = "hyundai";

        public string StartingSpeed(int speed)
        {
            if (speed < 0) throw new InvalidValueException();

            _currentSpeed = speed;
            return speed.ToString();
        }

        public string GetName()
        {
            return _name;
        }

        public string ShowCurrentSpeed()
        {
            return _currentSpeed.ToString();
        }

        public void SlowDown(int speed)
        {
            _currentSpeed -= speed;
        }

        public void SpeedUp(int speed)
        {
            _currentSpeed += speed;
        }

        public string StartEngine()
        {
            return " hyundai onomatopoeia - vivIIiiiiiiiiiiBRbbBrbbbRbbrrtBst";
        }
    }
}