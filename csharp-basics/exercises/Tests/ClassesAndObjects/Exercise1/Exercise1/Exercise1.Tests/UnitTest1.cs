using Exercise1.Exception;
using NUnit.Framework;

namespace Exercise1.Tests
{
    public class Tests
    {
        public Product _target;

        [SetUp]
        public void Setup()
        {
            _target = new Product("Acetyl-CoA", 8050, 1);
        }

        [Test]
        public void ShouldBeAbleToGiveValuesToProduct()
        {
            //Arrange
            var expectedName = "Acetyl-CoA";
            double expectedPrice = 8050;
            var expectedAmount = 1;

            //Act
            var actualName = _target.PrintName();
            var actualPrice = _target.PrintPrice();
            var actualAmount = _target.PrintQuantity();

            //Assert
            Assert.AreEqual(expectedName, actualName);
            Assert.AreEqual(expectedPrice, actualPrice);
            Assert.AreEqual(expectedAmount, actualAmount);
        }

        [Test]
        public void ShouldThrowErrorIfNameIsNotProvided()
        {
            //Arrange 
            var name = new Product(null, 8050, 1);

            //Assert
            Assert.Throws<OneOfValuesNotProvidedException>(() => name.PrintName());
        }

        [Test]
        public void ShouldThrowErrorIfPriceIsNotProvided()
        {
            //Arrange 
            var price = new Product("3-hydroxy-5-aminomethyl-1-isoxazole", 0, 1);

            //Assert
            Assert.Throws<OneOfValuesNotProvidedException>(() => price.PrintPrice());
        }

        [Test]
        public void ShouldThrowErrorIfQuantityIsNotProvided()
        {
            //Arrange 
            var quantity = new Product("Dinitrogen trioxide", 50, 0);

            //Assert
            Assert.Throws<OneOfValuesNotProvidedException>(() => quantity.PrintQuantity());
        }

        [Test]
        public void ShouldBeAbleToChangeName()
        {
            var name = new Product("BLACK MATTER", 1000000000000, 0.0000001);

            var expectedName = "BLACK MATTER";

            Assert.AreEqual(expectedName, name.PrintName());
        }

        [Test]
        public void ShouldThrowErrorIfNameIsNotProvidedWhileChangingValue()
        {
            //Assert
            Assert.Throws<OneOfValuesNotProvidedException>(() => _target.ChangeName(null));
        }

        [Test]
        public void ShouldBeAbleToChangePrice()
        {
            var name = new Product("BLACK MATTER", 1000000000000, 0.0000001);

            var expectedPrice = 1000000000000;

            Assert.AreEqual(expectedPrice, name.PrintPrice());
        }

        [Test]
        public void ShouldThrowErrorIfPriceIsNotProvidedWhileChangingValue()
        {
            //Assert
            Assert.Throws<OneOfValuesNotProvidedException>(() => _target.ChangePrice(0));
        }

        [Test]
        public void ShouldBeAbleToChangeQuantity()
        {
            var name = new Product("BLACK MATTER", 1000000000000, 0.0000001);

            var expectedQuantity = 0.0000001;

            Assert.AreEqual(expectedQuantity, name.PrintQuantity());
        }

        [Test]
        public void ShouldThrowErrorIfQuantityIsNotProvidedWhileChangingValue()
        {
            //Assert
            Assert.Throws<OneOfValuesNotProvidedException>(() => _target.ChangeQuantity(0));
        }
    }
}