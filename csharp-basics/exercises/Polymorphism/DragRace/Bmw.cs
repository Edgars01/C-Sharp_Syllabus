using System;

namespace DragRace
{
    public class Bmw : ICar
    {
        private int currentSpeed;
        private readonly string _name = "bmw";

        public void SpeedUp()
        {
            currentSpeed += 6;
        }

        public void SlowDown()
        {
            currentSpeed += 6;
        }

        public string ShowCurrentSpeed()
        {
            return currentSpeed.ToString();
        }

        public void StartEngine()
        {
            Console.WriteLine(" bmw onomatopoeia - brubmmmmMMMbruMMMMMMMMMMMMtututuututUTUtuutututu");
        }

        public string GetName()
        {
            return _name;
        }
    }
}