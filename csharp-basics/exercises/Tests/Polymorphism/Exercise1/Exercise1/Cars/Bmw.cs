using System;
using DragRace.Exception;

namespace DragRace
{
    public class Bmw : ICar
    {
        private int currentSpeed;
        private readonly string _name = "bmw";

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
            return " bmw onomatopoeia - brubmmmmMMMbruMMMMMMMMMMMMtututuututUTUtuutututu";
        }

        public string GetName()
        {
            return _name;
        }
    }
}