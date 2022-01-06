using NUnit.Framework;
using PhoneBook.Exception;

namespace PhoneBook.Tests
{
    public class Tests
    {
        private IPhoneBook _target;

        [SetUp]
        public void Setup()
        {
            _target = new PhoneBook();
        }

        [Test]
        public void ShouldTrowErrorIfNameIsNotProvided()
        {
            Assert.Throws<InvalidParametersprovidedException>(() => _target.AddNumber(null, "12345678"));
        }

        [Test]
        public void ShouldTrowErrorIfNumberIsNotProvided()
        {
            Assert.Throws<InvalidParametersprovidedException>(() => _target.AddNumber("name", null));
        }

        [Test]
        public void ShouldBeAbleToAddFirstNumberAndNameToPhoneBook()
        {
            _target.AddNumber("name", "12345678");

            Assert.AreEqual(1, _target.GetNumbers());
        }

        [Test]
        public void ShouldNotBeAbleToAddNumberToPhoneBookIfSameNumberAlreadyExists_ShouldFail()
        {
            _target.AddNumber("name", "12345679");

            Assert.Throws<DuplicatePhoneNumberException>(() => _target.AddNumber("troll", "12345679"));
        }

        [Test]
        public void FindingNumber_ShouldBeAbleToFindNumber()
        {
            var expected = "12345679";
            _target.AddNumber("name", "12345679");

            Assert.AreEqual(expected, _target.FindNumber("12345679"));
        }

        [Test]
        public void FindingNumber_ShouldBeAbleTrowErrorIfNumberDoesntExist()
        {
            Assert.Throws<PhoneNumberNotFoundException>(() => _target.FindNumber("12345679"));
        }

        [Test]
        public void ShouldBeAbleToRemoveNumber()
        {
            _target.AddNumber("name", "12345679");

            _target.RemoveNumber("12345679");

            Assert.Throws<PhoneNumberNotFoundException>(() => _target.FindNumber("12345679"));
        }

        [Test]
        public void ShouldNotBeAbleToRemoveNumberThatDoesntExist()
        {
            _target.RemoveNumber("12345679");

            Assert.Throws<PhoneNumberNotFoundException>(() => _target.FindNumber("12345679"));
        }
    }
}