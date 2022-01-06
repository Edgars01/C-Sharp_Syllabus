using Exercise8.Exception;
using NUnit.Framework;

namespace Exercise8.Tests
{
    public class Tests
    {
        private IExercise _target;

        [SetUp]
        public void Setup()
        {
            _target = new Exercise();
        }

        [Test]
        public void PayIsSmallerThanMinimalWage_ShouldFail()
        {
            Assert.Throws<InvalidWageException>(() => _target.CalculatePay(5, 50));
        }

        [Test]
        public void MoreHoursThanMaximumAllowedHours_ShouldFail()
        {
            Assert.Throws<InvalidHoursException>(() => _target.CalculatePay(8, 90));
        }

        [Test]
        public void SalaryShouldBe_SameAsExpectedWhen_PayIs8point20_Hours47()
        {
            double exception = 414;
            Assert.AreEqual(exception, _target.CalculatePay(8.20, 47));
        }
    }
}