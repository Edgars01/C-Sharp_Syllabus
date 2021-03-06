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
        public void CalculatePay_PayIsSmallerThanMinimalWage_ShouldFail()
        {
            //Arrange
            Assert.Throws<InvalidWageException>(() => _target.CalculatePay(5, 50));
        }

        [Test]
        public void CalculatePay_MoreHoursThanMaximumAllowedHours_ShouldFail()
        {
            //Arrange
            Assert.Throws<InvalidHoursException>(() => _target.CalculatePay(8, 90));
        }

        [Test]
        public void CalculatePay_SalaryShouldBeSameAsExpectedWhen_PayIs8point20Hours47()
        {
            //Arrange
            double exception = 414;
            //Assert
            Assert.AreEqual(exception, _target.CalculatePay(8.20, 47));
        }
    }
}