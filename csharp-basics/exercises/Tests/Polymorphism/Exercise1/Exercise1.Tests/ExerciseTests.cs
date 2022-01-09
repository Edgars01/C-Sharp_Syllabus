using System.Collections.Generic;
using DragRace;
using DragRace.Exception;
using NUnit.Framework;

namespace Exercise1.Tests
{
    public class Tests
    {
        private Tesla _tesla;
        private Hyundai _hyundai;
        private IFastestCar _target;

        public List<ICar> cars = new();

        [SetUp]
        public void Setup()
        {
            _tesla = new Tesla();

            _hyundai = new Hyundai();

            _target = new FastestCar();
        }

        [Test]
        public void ShouldGetFastestCarTESLA()
        {
            _tesla.SpeedUp(1000);
            cars.Add(_tesla);
            _hyundai.SpeedUp(2);
            cars.Add(_hyundai);

            var expected = "TESLA";

            var actual = _target.NameOFFastestCar(cars);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CarEngineSoundShouldBeSameAsExpected_Tesla()
        {
            var expected = " TESLA onomatopoeia ------------------- is it on?";

            var actual = _tesla.StartEngine();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ShouldPassIfCarHasN0S_Tesla()
        {
            var isBoostable = _tesla is IBoostable;

            Assert.IsFalse(isBoostable);
        }

        [Test]
        public void CarShouldHaveName_Tesla()
        {
            var expected = "TESLA";

            var actual = _tesla.GetName();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ShouldBeAbleToSeeCurrentSpeed_Tesla()
        {
            var expected = "0";

            var actual = _tesla.ShowCurrentSpeed();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ShouldBeAbleToSeeSpeedAfterSpeedUp_Tesla()
        {
            var expected = "85";

            _tesla.SpeedUp(85);
            var actual = _tesla.ShowCurrentSpeed();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ShouldBeAbleToSeeCurrentSpeedAfterSlowDown_Tesla()
        {
            var expected = "170";

            _tesla.SpeedUp(170);
            _tesla.SlowDown(0);

            var actual = _tesla.ShowCurrentSpeed();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SpeedCantBeNegative_Tesla()
        {
            Assert.Throws<InvalidValueException>(() => _tesla.StartingSpeed(-1));
        }

        [Test]
        public void ICarShouldBeTrue_Tesla()
        {
            var isCar = _tesla is ICar;

            Assert.IsTrue(isCar);
        }

        [Test]
        public void CarEngineSoundShouldBeSameAsExpected_Hyundai()
        {
            var expected = " hyundai onomatopoeia - vivIIiiiiiiiiiiBRbbBrbbbRbbrrtBst";

            var actual = _hyundai.StartEngine();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ShouldPassIfCarHasN0S_Hyundai()
        {
            var isBoostable = _hyundai is IBoostable;

            Assert.IsFalse(isBoostable);
        }

        [Test]
        public void CarShouldHaveName_Hyundai()
        {
            var expected = "hyundai";

            var actual = _hyundai.GetName();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ShouldBeAbleToSeeCurrentSpeed_Hyundai()
        {
            var expected = "0";

            var actual = _hyundai.ShowCurrentSpeed();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ShouldBeAbleToSeeSpeedAfterSpeedUp_Hyundai()
        {
            var expected = "6";

            _hyundai.SpeedUp(6);
            var actual = _hyundai.ShowCurrentSpeed();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ShouldBeAbleToSeeCurrentSpeedAfterSlowDown_Hyundai()
        {
            var expected = "0";

            _hyundai.SpeedUp(10);
            _hyundai.SlowDown(10);

            var actual = _hyundai.ShowCurrentSpeed();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SpeedCantBeNegative_Hyundai()
        {
            Assert.Throws<InvalidValueException>(() => _hyundai.StartingSpeed(-1));
        }

        [Test]
        public void ICarShouldBeTrue_Hyundai()
        {
            var isCar = _hyundai is ICar;

            Assert.IsTrue(isCar);
        }
    }
}