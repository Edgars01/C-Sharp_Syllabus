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
        public void AreaOfCircleTest_IncorrectRadius_ShouldReturnException()
        {
            //Assert
            Assert.Throws<IncorrectAreaOfCircleException>(() => _target.AreaOfCircle(0));
        }

        [Test]
        public void AreaOfRectangleTest_IncorrectLengthWidth_ShouldReturnException()
        {
            //Assert
            Assert.Throws<IncorrectAreaOfRectangleException>(() => _target.AreaOfRectangle(2, 0));
        }

        [Test]
        public void AreaOfRectangleTest_IncorrectLength_ShouldReturnException()
        {
            //Assert
            Assert.Throws<IncorrectAreaOfRectangleException>(() => _target.AreaOfRectangle(0, 2));
        }

        [Test]
        public void AreaOfTriangleTest_IncorrectGround_ShouldReturnException()
        {
            //Assert
            Assert.Throws<IncorrectAreaOfTriangleException>(() => _target.AreaOfTriangle(0, 2));
        }

        [Test]
        public void AreaOfTriangleTest_IncorrectHeight_ShouldReturnException()
        {
            //Assert
            Assert.Throws<IncorrectAreaOfTriangleException>(() => _target.AreaOfTriangle(2, 0));
        }

        [Test]
        public void AreaOfCircleTest_radiusWithValue5_ShouldArea78point5()
        {
            //Arrange
            var expected = 78.5;
            //Assert
            Assert.AreEqual(expected, _target.AreaOfCircle(5));
        }

        [Test]
        public void AreaOfRectangleTest_length5Width6_ShouldReturnArea30()
        {
            //Arrange
            var expected = 30;
            //Assert
            Assert.AreEqual(expected, _target.AreaOfRectangle(5, 6));
        }

        [Test]
        public void AreaOfTriangleTest_Ground7Height12_ShouldReturnArea42()
        {
            //Arrange
            var expected = 42;
            //Assert
            Assert.AreEqual(expected, _target.AreaOfTriangle(7, 12));
        }
    }
}