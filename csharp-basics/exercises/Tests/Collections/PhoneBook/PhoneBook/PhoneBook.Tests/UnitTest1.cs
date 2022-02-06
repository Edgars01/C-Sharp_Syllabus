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
        public void AddNumber_NoNameProvided_ShouldFail()
        {
            //Assert
            Assert.Throws<InvalidParametersprovidedException>(() => _target.AddNumber(null, "12345678"));
        }

        [Test]
        public void AddNumber_NoNumberProvided_ShouldFail()
        {
            //Assert
            Assert.Throws<InvalidParametersprovidedException>(() => _target.AddNumber("name", null));
        }

        [Test]
        public void ShouldBeAbleToAddFirstNumberAndNameToPhoneBook()
        {
            //Arrange
            _target.AddNumber("name", "12345678");
            //Assert
            Assert.AreEqual(1, _target.GetNumbers());
        }

        [Test]
        public void AddNumber_AddingDuplicateNumber_ShouldFail()
        {
            //Arrange
            _target.AddNumber("name", "12345679");
            //Assert
            Assert.Throws<DuplicatePhoneNumberException>(() => _target.AddNumber("troll", "12345679"));
        }

        [Test]
        public void FindingNumber_12345679_ShouldBesameAsExpected()
        {
            //Arrange
            var expected = "12345679";
            _target.AddNumber("name", "12345679");
            //Assert
            Assert.AreEqual(expected, _target.FindNumber("12345679"));
        }

        [Test]
        public void FindingNumber_ProvidedNumberDoesntExist_ShouldFail()
        {
            //Assert
            Assert.Throws<PhoneNumberNotFoundException>(() => _target.FindNumber("12345679"));
        }

        [Test]
        public void FindNumber_12345679AfterRemovingIt_ShouldFail()
        {
            //Arrange
            _target.AddNumber("name", "12345679");
            _target.RemoveNumber("12345679");
            //Assert
            Assert.Throws<PhoneNumberNotFoundException>(() => _target.FindNumber("12345679"));
        }

        [Test]
        public void FindNumber_NumberThatDoesntExist_ShouldFail()
        {
            //Arrange
            _target.RemoveNumber("12345679");
            //Assert
            Assert.Throws<PhoneNumberNotFoundException>(() => _target.FindNumber("12345679"));
        }
    }
}