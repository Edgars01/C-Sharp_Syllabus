using DragRace.Exception;

namespace DragRace
{
    public class Tesla : ICar
    {
        private int currentSpeed = 0;
        private string _name = "TESLA";

        public string StartingSpeed(int speed)
        {
            if (speed < 0) throw new InvalidValueException();

            currentSpeed = speed;
            return speed.ToString();
        }

        public void SpeedUp(int speed)
        {
            currentSpeed += speed;
        }

        public void SlowDown(int speed)
        {
            currentSpeed += speed;
        }

        public string ShowCurrentSpeed()
        {
            return currentSpeed.ToString();
        }

        public string StartEngine()
        {
            return " TESLA onomatopoeia ------------------- is it on?";
        }

        public string GetName()
        {
            return _name;
        }
    }
}