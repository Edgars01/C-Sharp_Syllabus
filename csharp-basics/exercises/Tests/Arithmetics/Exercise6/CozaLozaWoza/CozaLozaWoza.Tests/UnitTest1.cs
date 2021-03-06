using System;
using NUnit.Framework;

namespace CozaLozaWoza.Tests
{
    public class Tests
    {
        private CozaLozaWoza _target;

        [SetUp]
        public void Setup()
        {
            _target = new CozaLozaWoza();
        }

        [Test]
        public void FirstSymbolShouldBe_1()
        {
            //Arrange
            string expectedResult = "1 ";
            //Assert
            Assert.AreEqual(expectedResult, _target.ConvertToCozaLozaWozaElement(1));
        }

        [Test]
        public void LastSymbolShouldBe_Loza()
        {
            //Arrange
            string expectedResult = "Loza ";
            //Assert
            Assert.AreEqual(expectedResult, _target.ConvertToCozaLozaWozaElement(110));
        }

        [Test]
        public void NumberThatDividesBySeven_ReturnWoza()
        {
            //Arrange
            string expectedResult = "Woza ";
            //Assert
            Assert.AreEqual(expectedResult, _target.ConvertToCozaLozaWozaElement(7));
        }

        [Test]
        public void NumberThatDividesByFive_ReturnLoza()
        {
            //Arrange
            string expectedResult = "Loza ";
            //Assert
            Assert.AreEqual(expectedResult, _target.ConvertToCozaLozaWozaElement(5));
        }

        [Test]
        public void NumberThatDividesByThree_ReturnCoza()
        {
            //Arrange
            string expectedResult = "Coza ";
            //Assert
            Assert.AreEqual(expectedResult, _target.ConvertToCozaLozaWozaElement(3));
        }

        [Test]
        public void NumberThatDividesByThreeAndFive_ReturnCozaLoza()
        {
            //Arrange
            string expectedResult = "CozaLoza ";
            //Assert
            Assert.AreEqual(expectedResult, _target.ConvertToCozaLozaWozaElement(15));
        }

        [Test]
        public void NumberThatDividesBySevenAndFive_ReturnLozaCoza()
        {
            //Arrange
            string expectedResult = "LozaCoza ";
            //Assert
            Assert.AreEqual(expectedResult, _target.ConvertToCozaLozaWozaElement(35));
        }

        [Test]
        public void Test()
        {
            //Arrange
            string expectedResult = Environment.NewLine + "11";
            //Assert
            Assert.AreEqual(expectedResult, _target.ConvertToCozaLozaWozaElement(11));
        }
    }
}