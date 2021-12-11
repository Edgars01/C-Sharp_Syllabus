namespace Exercise_9
{
    public class PointsToSwap
    {
        public int _x;
        public int _y;

        public PointsToSwap(int x, int y)
        {
            this._x = x;
            this._y = y;
        }

        public static void Swap(ref PointsToSwap x, ref PointsToSwap y)
        {
            (x, y) = (y, x);
        }
    }
}
