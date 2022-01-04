using System;

namespace DragRace
{
    public class Audi : ICar , IBoostable
    {
        private int currentSpeed = 0;
        private string _name = "audi";

        public void SpeedUp() 
        {
            currentSpeed += 7;
        }

        public void SlowDown() 
        {
            currentSpeed -= 7;
        }

        public string ShowCurrentSpeed() 
        {
            return currentSpeed.ToString();
        }

        public void StartEngine() 
        {
            Console.WriteLine(" audi onomatopoeia - BraPapAPAPAPAAPPA");
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