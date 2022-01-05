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
        public void GravityValueShouldBe_SameAsExpected()
        {
            var expected = -9.81;
            Assert.AreEqual(expected, _target.Gravity());
        }

        [Test]
        public void InitialVelocityValueShouldBe_SameAsExpected()
        {
            var expected = 0.0;
            Assert.AreEqual(expected, _target.InitialVelocity());
        }

        [Test]
        public void FallingTimeValueShouldBe_SameAsExpected()
        {
            var expected = 10.0;
            Assert.AreEqual(expected, _target.FallingTime());
        }

        [Test]
        public void InitialPositionShouldBe_SameAsExpected()
        {
            var expected = 0.0;
            Assert.AreEqual(expected, _target.InitialPosition());
        }

        [Test]
        public void PositionFallingForTenSecondsShouldBe_SameAsExpected()
        {
            var expected = -490.5;
            Assert.AreEqual(expected, _target.FinalPositionAfterTenSec());
        }

        [Test]
        public void PositionFallingFor51SecondsShouldBe_SameAsExpected()
        {
            var expected = -12757.905;
            Assert.AreEqual(expected, _target.FinalPositionAfter51Sec());
        }
    }
}