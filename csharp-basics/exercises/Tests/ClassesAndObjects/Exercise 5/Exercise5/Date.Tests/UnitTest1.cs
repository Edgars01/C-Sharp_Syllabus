using Date.Tests.Exception;
using NUnit.Framework;

namespace Date.Tests
{
    public class Tests
    {
        private Exercise5.Date _target;

        [SetUp]
        public void Setup()
        {
            _target = new Exercise5.Date(1, 1, 1);
        }

        [Test]
        public void DisplayDate_ProvidingExpectedDate_ShouldBeEqualToResult()
        {
            //Arrange
            const string expected = "1 / 1 / 1";
            var actual = _target.DisplayDate();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        [TestCase(1212, 12, 0)]
        [TestCase(13331, -111, 11111)]
        [TestCase(333, 1, 9090)]
        public void ShouldBeAbleToShowExceptionOnWrongDateInput(int month, int day, int year)
        {
            //Assert
            Assert.Throws<InvalidDateException>(() => new Exercise5.Date(-1, -1, -1));
        }
    }
}