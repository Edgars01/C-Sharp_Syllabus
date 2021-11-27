namespace CalculateArea
{
    public class Geometry
    {
        public static double AreaOfCircle(int radius)
        {
            double area = (3.14) * radius * radius;
            return area;
        }

        public static double AreaOfRectangle(int length, int width)
        {
            double area = length * width;
            return area;
        }

        public static double AreaOfTriangle(int ground, int h)
        {
            double area = ground * h * 0.5;
            return area;
        }
    }
}
