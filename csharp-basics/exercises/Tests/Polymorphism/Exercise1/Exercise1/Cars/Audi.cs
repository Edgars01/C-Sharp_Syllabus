using System;
using DragRace.Exception;

namespace DragRace
{
    public class Audi : ICar, IBoostable
    {
        private int currentSpeed = 0;
        private string _name = "audi";

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
            currentSpeed -= speed;
        }

        public string ShowCurrentSpeed()
        {
            return currentSpeed.ToString();
        }

        public string StartEngine()
        {
            return " audi onomatopoeia - BraPapAPAPAPAAPPA";
        }

        public void UseNitrousOxideEngine()
        {
            currentSpeed += 2;
        }

        public string GetName()
        {
            return _name;
        }
    }
}