using System;
using Exercise10.Exceptoon;

namespace Exercise10
{
    public class ExerciseTen : IExerciseTen
    {
        public double AreaOfCircle(double radius)
        {
            if (radius < 1) throw new IncorrectAreaOfCircleException();
            return 3.14 * radius * radius;
        }

        public double AreaOfRectangle(double length, double width)
        {
            if (width < 1) throw new IncorrectAreaOfRectangleException();
            if (length < 1) throw new IncorrectAreaOfRectangleException();
            return length * width;
        }

        public double AreaOfTriangle(double ground, double height)
        {
            if (ground < 1) throw new IncorrectAreaOfTriangleException();
            if (height < 1) throw new IncorrectAreaOfTriangleException();
            return ground * height * 0.5;
        }
    }
}
