using System;
using DragRace.Exception;

namespace DragRace
{
    public class Lexus : ICar, IBoostable
    {
        private int currentSpeed = 0;
        private string _name = "lexus";

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

        public void UseNitrousOxideEngine()
        {
            currentSpeed += 2;
        }

        public string StartEngine()
        {
            return " lexus onomatopoeia - brbbrbbbrbbbrb";
        }

        public string GetName()
        {
            return _name;
        }
    }
}