using Exercise_6.Exception;
using NUnit.Framework;

namespace Hierarchy.Tests
{
    public class Tests
    {
       
        private Mouse _mouse;
        private Cat _cat;
        private Vegetable _vegetable;
        private Meat _meat;

        [SetUp]
        public void Setup()
        {
            _mouse = new Mouse("mouse", "mammal", 2, 0, "basement");
            _cat = new Cat("cat", "feline", 5, 0, "near basement", "unknown");
            _vegetable = new Vegetable("Vegetable", 2);
            _meat = new Meat("Meat");
        }


        [Test]
        public void ShouldReturnRightParameters_Mouse()
        {
            var expected = "mammal mouse 2 0, basement";
            var actual = _mouse.ReturnInfo();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ShouldReturnRightParameters_Cat()
        {
            var expected = "feline cat 5 0, near basement";
            var actual = _cat.ReturnInfo();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ShouldNotBeAbleToGiveAnimalWrongFood_Cat()
        {
            Assert.Throws<InvalidParameterTypeException>(() => _cat.Eat(_vegetable));
        }

        [Test]
        public void ShouldNotBeAbleToGiveAnimalWrongFood_Mouse()
        {
            Assert.Throws<InvalidParameterTypeException>(() => _mouse.Eat(_meat));
        }

        [Test]
        public void AnimalShouldBeAbleToSayThanksWhenGivenFood_Cat()
        {
            var expected = "thanks";
            var actual = _cat.Eat(_meat);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AnimalShouldBeAbleToSayThanksWhenGivenFood_Mouse()
        {
            var expected = "thanks";
            var actual = _mouse.Eat(_vegetable);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ShouldBeAbleToGetFoodType_vegetable()
        {
            var expected = "Vegetable";
            var actual = _vegetable.GetFoodType();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ShouldBeAbleToGetFoodType_Meat()
        {
            var expected = "Meat";
            var actual = _meat.GetFoodType();

            Assert.AreEqual(expected, actual);
        }
    }
}