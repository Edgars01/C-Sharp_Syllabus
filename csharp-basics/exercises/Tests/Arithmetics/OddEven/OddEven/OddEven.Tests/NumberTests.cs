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
        public void ShouldBeAbleToDetermineIfValueIsEvenNumber()
        {
            var result = _target.IsOddOrEven(2);

            Assert.AreEqual("Even", result);
        }

        [Test]
        public void ShouldBeAbleToDetermineIfValueIsOddNumber()
        {
            var result = _target.IsOddOrEven(5);

            Assert.AreEqual("Odd", result);
        }

        [Test]
        public void ShouldBeAbleToThrowErrorOnNegativeValue()
        {
            Assert.Throws<InvalidValueException>(() => _target.IsOddOrEven(-5));
        }
    }
}