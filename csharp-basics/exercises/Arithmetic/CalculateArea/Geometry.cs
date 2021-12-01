namespace CalculateArea
{
    public class Geometry
    {
        public static double AreaOfCircle(int radius)
        {
            return (3.14) * radius * radius;    
        }

        public static double AreaOfRectangle(int length, int width)
        {
            return length * width;          
        }

        public static double AreaOfTriangle(int ground, int h)
        {
            return ground * h * 0.5; 
        }
    }
}
