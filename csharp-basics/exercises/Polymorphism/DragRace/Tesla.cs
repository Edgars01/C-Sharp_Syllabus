using System;

namespace DragRace
{
    public class Tesla : ICar
    {
        private int currentSpeed = 0;
        private string _name = "TESLA";

        public void SpeedUp() 
        {
            currentSpeed += 85;
        }

        public void SlowDown() 
        {
            currentSpeed += 85;
        }

        public string ShowCurrentSpeed() 
        {
            return currentSpeed.ToString();
        }

        public void StartEngine() 
        {
            Console.WriteLine(" TESLA onomatopoeia ------------------- is it on?");
        }

        public string GetName()
        {
            return _name;
        }
    }
}