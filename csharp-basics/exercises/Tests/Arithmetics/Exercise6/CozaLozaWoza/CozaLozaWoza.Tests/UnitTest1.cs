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
            string expectedResult = "1 ";
            Assert.AreEqual(expectedResult, _target.Conditions(1));
        }

        [Test]
        public void LastSymbolShouldBe_Loza()
        {
            string expectedResult = "Loza ";
            Assert.AreEqual(expectedResult, _target.Conditions(110));
        }

        [Test]
        public void NumberThatDividesBySeven_ReturnWoza()
        {
            string expectedResult = "Woza ";
            Assert.AreEqual(expectedResult, _target.Conditions(7));
        }

        [Test]
        public void NumberThatDividesByFive_ReturnLoza()
        {
            string expectedResult = "Loza ";
            Assert.AreEqual(expectedResult, _target.Conditions(5));
        }

        [Test]
        public void NumberThatDividesByThree_ReturnCoza()
        {
            string expectedResult = "Coza ";
            Assert.AreEqual(expectedResult, _target.Conditions(3));
        }

        [Test]
        public void NumberThatDividesByThreeAndFive_ReturnCozaLoza()
        {
            string expectedResult = "CozaLoza ";
            Assert.AreEqual(expectedResult, _target.Conditions(15));
        }

        [Test]
        public void NumberThatDividesBySevenAndFive_ReturnLozaCoza()
        {
            string expectedResult = "LozaCoza ";
            Assert.AreEqual(expectedResult, _target.Conditions(35));
        }
    }
}