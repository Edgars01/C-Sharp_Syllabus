using NUnit.Framework;
using OddEven.Exceptions;

namespace OddEven.Tests
{
    public class Tests
    {
        private IOddEven _target;

        [SetUp]
        public void Setup()
        {
            _target = new OddEven();
        }

        [Test]
        public void IsOddOrEven_ShouldBeAbleToDetermineIfValueIsEvenNumber()
        {
            //Arrange
            var result = _target.IsOddOrEven(2);
            //Assert
            Assert.AreEqual("Even", result);
        }

        [Test]
        public void IsOddOrEven_ShouldBeAbleToDetermineIfValueIsOddNumber()
        {
            //Arrange
            var result = _target.IsOddOrEven(5);
            //Assert
            Assert.AreEqual("Odd", result);
        }

        [Test]
        public void IsOddOrEven_ShouldBeAbleToThrowErrorOnNegativeValue()
        {
            //Assert
            Assert.Throws<InvalidValueException>(() => _target.IsOddOrEven(-5));
        }
    }
}