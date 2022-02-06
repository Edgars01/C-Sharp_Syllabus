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
        public void PrintName_ShouldThrowErrorIfNameIsNotProvided()
        {
            //Arrange 
            var name = new Product(null, 8050, 1);

            //Assert
            Assert.Throws<OneOfValuesNotProvidedException>(() => name.PrintName());
        }

        [Test]
        public void PrintPrice_ShouldThrowErrorIfPriceIsNotProvided()
        {
            //Arrange 
            var price = new Product("3-hydroxy-5-aminomethyl-1-isoxazole", 0, 1);

            //Assert
            Assert.Throws<OneOfValuesNotProvidedException>(() => price.PrintPrice());
        }

        [Test]
        public void PrintQuantity_ShouldThrowErrorIfQuantityIsNotProvided()
        {
            //Arrange 
            var quantity = new Product("Dinitrogen trioxide", 50, 0);

            //Assert
            Assert.Throws<OneOfValuesNotProvidedException>(() => quantity.PrintQuantity());
        }

        [Test]
        public void PrintName_ShouldBeAbleToChangeName()
        {
            //Arrange 
            var name = new Product("BLACK MATTER", 1000000000000, 0.0000001);
            var expectedName = "BLACK MATTER";

            //Assert
            Assert.AreEqual(expectedName, name.PrintName());
        }

        [Test]
        public void ChangeName_ShouldThrowErrorIfNameIsNotProvidedWhileChangingValue()
        {
            //Assert
            Assert.Throws<OneOfValuesNotProvidedException>(() => _target.ChangeName(null));
        }

        [Test]
        public void PrintPrice_ProvidingCorrectData_ExpectedPriceShouldBe1000000000000()
        {
            //Arrange
            var name = new Product("BLACK MATTER", 1000000000000, 0.0000001);
            var expectedPrice = 1000000000000;

            //Assert
            Assert.AreEqual(expectedPrice, name.PrintPrice());
        }

        [Test]
        public void ChangePrice_PriceZero_ShouldFail()
        {
            //Assert
            Assert.Throws<OneOfValuesNotProvidedException>(() => _target.ChangePrice(0));
        }

        [Test]
        public void PrintQuantity_ProvidingSuitableData_ExpectedQuantityShouldBe_0Point0000001()
        {
            //Arrange
            var name = new Product("BLACK MATTER", 1000000000000, 0.0000001);
            var expectedQuantity = 0.0000001;
            //Assert
            Assert.AreEqual(expectedQuantity, name.PrintQuantity());
        }

        [Test]
        public void ChangeQuantity_AmountZero_ShouldFail()
        {
            //Assert
            Assert.Throws<OneOfValuesNotProvidedException>(() => _target.ChangeQuantity(0));
        }
    }
}