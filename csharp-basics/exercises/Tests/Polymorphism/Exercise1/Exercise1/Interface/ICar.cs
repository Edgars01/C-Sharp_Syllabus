namespace DragRace
{
    public interface ICar
    {
        void SpeedUp(int speed);
        void SlowDown(int speed);
        string ShowCurrentSpeed();
        string StartEngine();
        string GetName();
    }
}