using NUnit.Framework;

namespace Exercise7.Tests
{
    public class Tests
    {
        private ICalculate _target;

        [SetUp]
        public void Setup()
        {
            _target = new Calculate();
        }

        [Test]
        public void GravityValue_ShouldBeSameAsExpectedValue()
        {
            //Arrange
            var expected = -9.81;
            //Assert
            Assert.AreEqual(expected, _target.Gravity());
        }

        [Test]
        public void InitialVelocity_ShouldBeSameAsExpected()
        {
            //Arrange
            var expected = 0.0;
            //Assert
            Assert.AreEqual(expected, _target.InitialVelocity());
        }

        [Test]
        public void FallingTimeValue_ShouldBeSameAsExpected()
        {
            //Arrange
            var expected = 10.0;
            //Assert
            Assert.AreEqual(expected, _target.FallingTime());
        }

        [Test]
        public void InitialPosition_ShouldBeSameAsExpected()
        {
            //Arrange
            var expected = 0.0;
            //Assert
            Assert.AreEqual(expected, _target.InitialPosition());
        }

        [Test]
        public void PositionFallingForTenSeconds_ShouldBeSameAsExpected()
        {
            //Arrange
            var expected = -490.5;
            //Assert
            Assert.AreEqual(expected, _target.FinalPositionAfterTenSec());
        }

        [Test]
        public void PositionFallingFor51Seconds_ShouldBeSameAsExpected()
        {
            //Arrange
            var expected = -12757.905;
            //Assert
            Assert.AreEqual(expected, _target.FinalPositionAfter51Sec());
        }
    }
}