using System;

namespace DragRace
{
    public class Lexus : ICar, IBoostable
    {
        private int currentSpeed = 0;
        private string _name = "lexus";

        public void SpeedUp() 
        {
            currentSpeed += 5;
        }

        public void SlowDown() 
        {
            currentSpeed += 5;
        }

        public string ShowCurrentSpeed() 
        {
            return currentSpeed.ToString();
        }

        public void UseNitrousOxideEngine() 
        {
            currentSpeed += 2;
        }

        public void StartEngine() 
        {
            Console.WriteLine(" lexus onomatopoeia - brbbrbbbrbbbrb");
        }

        public string GetName()
        {
            return _name;
        }
    }
}