using Fifteen.Exceptions;
using NUnit.Framework;

namespace Fifteen.Tests
{
    public class Tests
    {
        private IFifteen _target;

        [SetUp]
        public void Setup()
        {
            _target = new Fifteen();
        }

        [Test]
        public void Adding_15_and_0_ShouldPass()
        {   
            // Arrange
            _target.IsSumValidAdding(15, 0);


            // Assert
            Assert.Pass();
        }

        [Test]
        public void Adding_0_and_15_ShouldPass()
        {
            // Arrange
            _target.IsSumValidAdding(0, 15);


            // Assert
            Assert.Pass();
        }

        [Test]
        public void Adding_7_and_8_ShouldPass()
        {
            // Arrange
            _target.IsSumValidAdding(7, 8);

            // Assert
            Assert.Pass();
        }

        [Test]
        public void ValueMinusValueIs15_ShouldPass()
        {
            // Arrange
            _target.IsSumValidMinus(16, 1);

            // Assert
            Assert.Pass();
        }

        [Test]
        public void AddingNegativeValue_ShouldNotPass()
        {
            // Act
            Assert.Throws<InvalidNumberException>(() => _target.AddAnB(-2, 7));
        }

        [Test]
        public void AddingValuesThatSumIsBiggerThan15_ShouldNotPass()
        {
            // Act
            Assert.Throws<InvalidNumberException>(() => _target.AddAnB(15, 90));
        }
    }
}