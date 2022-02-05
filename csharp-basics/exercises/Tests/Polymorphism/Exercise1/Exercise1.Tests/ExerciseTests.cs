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
        public void NameOFFastestCar_TeslaPlus1000Speed_ShouldBeFastestCar()
        {
            //Arrange
            _tesla.SpeedUp(1000);
            cars.Add(_tesla);
            _hyundai.SpeedUp(2);
            cars.Add(_hyundai);

            //Act
            var expected = "TESLA";
            var actual = _target.NameOFFastestCar(cars);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void StartEngine_Tesla_ShouldMakeNoSound()
        {
            //Act
            var expected = " TESLA onomatopoeia ------------------- is it on?";

            var actual = _tesla.StartEngine();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ShouldPassIfCarHasN0S_Tesla()
        {
            //Arrange
            var isBoostable = _tesla is IBoostable;
            //Assert
            Assert.IsFalse(isBoostable);
        }

        [Test]
        public void GetName_Tesla_ShouldBeCalledTESLA()
        {
            //Act
            var expected = "TESLA";
            var actual = _tesla.GetName();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ShowCurrentSpeed_TeslaNotMoving_ShouldBe0()
        {
            //Act
            var expected = "0";
            var actual = _tesla.ShowCurrentSpeed();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ShowCurrentSpeed_TeslaAtSpeed85_ShouldBe85()
        {
            //Arrange
            _tesla.SpeedUp(85);
            var actual = _tesla.ShowCurrentSpeed();

            //Act
            var expected = "85";

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ShowCurrentSpeed_TeslaBeforeSlowDownSpeed170_ShouldBe170AfterSlowdown()
        {
            //Arrange
            _tesla.SpeedUp(170);
            _tesla.SlowDown(0);

            //Act
            var expected = "170";
            var actual = _tesla.ShowCurrentSpeed();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void StartingSpeed_StartWithNegativeSpeed_ShouldFail()
        {
            //Assert
            Assert.Throws<InvalidValueException>(() => _tesla.StartingSpeed(-1));
        }

        [Test]
        public void ICarShouldBeTrue_Tesla()
        {
            //Arrange
            var isCar = _tesla is ICar;
            //Assert
            Assert.IsTrue(isCar);
        }

        [Test]
        public void StartEngine_hyundai_ShouldMakeSoundHyundaiOnomatopoeia()
        {
            //Arrange
            var expected = " hyundai onomatopoeia - vivIIiiiiiiiiiiBRbbBrbbbRbbrrtBst";
            //Act
            var actual = _hyundai.StartEngine();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ShouldPassIfCarHasN0S_Hyundai()
        {
            //Arrange
            var isBoostable = _hyundai is IBoostable;
            //Assert
            Assert.IsFalse(isBoostable);
        }

        [Test]
        public void CarShouldHaveName_Hyundai()
        {
            //Act
            var expected = "hyundai";
            var actual = _hyundai.GetName();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ShowCurrentSpeed_HyundaiStartingSpeed_ShouldBe0()
        {
            //Act
            var expected = "0";
            var actual = _hyundai.ShowCurrentSpeed();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ShowCurrentSpeed_hyundaiAfterSpeedUp6_ShouldBe6()
        {
            //Arrange
            _hyundai.SpeedUp(6);
            //Act
            var expected = "6";
            var actual = _hyundai.ShowCurrentSpeed();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ShowCurrentSpeed_AfterBrake10AndSpeed10_ShouldBe0()
        {
            
            //Arrange
            _hyundai.SpeedUp(10);
            _hyundai.SlowDown(10);

            //Act
            var expected = "0";
            var actual = _hyundai.ShowCurrentSpeed();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SpeedCantBeNegative_Hyundai()
        {
            //Assert
            Assert.Throws<InvalidValueException>(() => _hyundai.StartingSpeed(-1));
        }

        [Test]
        public void ICarShouldBeTrue_Hyundai()
        {
            //Act
            var isCar = _hyundai is ICar;
            //Assert
            Assert.IsTrue(isCar);
        }
    }
}