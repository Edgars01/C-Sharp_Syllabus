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
            _target.CheckingIfProvidedNumberSumIsEqualTo_15(15, 0);

            // Assert
            Assert.Pass();
        }

        [Test]
        public void Adding_0_and_15_ShouldPass()
        {
            // Arrange
            _target.CheckingIfProvidedNumberSumIsEqualTo_15(0, 15);

            // Assert
            Assert.Pass();
        }

        [Test]
        public void Adding_7_and_8_ShouldPass()
        {
            // Arrange
            _target.CheckingIfProvidedNumberSumIsEqualTo_15(7, 8);

            // Assert
            Assert.Pass();
        }

        [Test]
        public void ValueMinusValueIs15_ShouldPass()
        {
            // Arrange
            _target.CheckingIfProvidedNumberMinusOtherNumberIsEqualTo_15(16, 1);

            // Assert
            Assert.Pass();
        }

        [Test]
        public void AddingNegativeValue_ShouldNotPass()
        {
            // Act
            Assert.Throws<InvalidNumberException>(() => _target.CheckingIfNumbersProvidedAreSmallerThanZero_OrTheirSumExceeds_15(-2, 7));
        }

        [Test]
        public void AddingValuesThatSumIsBiggerThan15_ShouldNotPass()
        {
            // Act
            Assert.Throws<InvalidNumberException>(() => _target.CheckingIfNumbersProvidedAreSmallerThanZero_OrTheirSumExceeds_15(15, 90));
        }
    }
}