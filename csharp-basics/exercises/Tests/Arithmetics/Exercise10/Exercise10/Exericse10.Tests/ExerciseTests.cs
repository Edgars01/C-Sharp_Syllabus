using System.Runtime.Serialization.Formatters;
using Exercise10;
using Exercise10.Exceptoon;
using NUnit.Framework;

namespace Exericse10.Tests
{
    public class Tests
    {
        private IExerciseTen _target;

        [SetUp]
        public void Setup()
        {
            _target = new ExerciseTen();
        }

        [Test]
        public void AreaOfCircleShouldBeBiggerThanOne()
        {
            Assert.Throws<IncorrectAreaOfCircleException>(() => _target.AreaOfCircle(0));
        }

        [Test]
        public void AreaOfRectangle_Width_ShouldBeBiggerThanOne()
        {
            Assert.Throws<IncorrectAreaOfRectangleException>(() => _target.AreaOfRectangle(2, 0));
        }

        [Test]
        public void AreaOfRectangle_Length_ShouldBeBiggerThanOne()
        {
            Assert.Throws<IncorrectAreaOfRectangleException>(() => _target.AreaOfRectangle(0, 2));
        }

        [Test]
        public void AreaOfTriangle_Ground_ShouldBeBiggerThanOne()
        {
            Assert.Throws<IncorrectAreaOfTriangleException>(() => _target.AreaOfTriangle(0, 2));
        }

        [Test]
        public void AreaOfTriangle_Height_ShouldBeBiggerThanOne()
        {
            Assert.Throws<IncorrectAreaOfTriangleException>(() => _target.AreaOfTriangle(2, 0));
        }

        [Test]
        public void ShouldBeAbleToCalculateTheAreaOfACircle()
        {
            double expected = 78.5;
            Assert.AreEqual(expected, _target.AreaOfCircle(5));
        }

        [Test]
        public void ShouldBeAbleToCalculateTheAreaOfRectangle()
        {
            double expected = 30;
            Assert.AreEqual(expected, _target.AreaOfRectangle(5, 6));
        }

        [Test]
        public void ShouldBeAbleToCalculateTheAreaOfTriangle()
        {
            double expected = 42;
            Assert.AreEqual(expected, _target.AreaOfTriangle(7, 12));
        }
    }
}