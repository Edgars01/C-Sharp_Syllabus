using Account.Expection;
using NUnit.Framework;

namespace Account.Tests
{
    public class Tests
    {
        private Account _target;

        [SetUp]
        public void Setup()
        {
            _target = new Account("Gallus Eberhard", 10000000);
        }

        [Test]
        public void ShouldBeAbleToGiveNameToAccount()
        {
            var expected = "Gallus Eberhard";

            var actual = _target.Name;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        [TestCase(null, 10000000)]
        [TestCase("Gallus Eberhard", -1)]
        public void ShouldBeAbleToTrowExceptionIfNoNameIsProvided(string userAccountName, decimal userAccountBalance)
        {
            Assert.Throws<NoDataProvidedException>(() => new Account(userAccountName, userAccountBalance));
        }

        [Test]
        public void ShouldBeAbleToDeposit()
        {
            var expected = 10000010;

            _target.Deposit(10);

            var actual = _target.Balance();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ShouldBeAbleToWithdrawal()
        {
            var expected = 9999999;

            _target.Withdrawal(1);

            var actual = _target.Balance();

            Assert.AreEqual(expected, actual);
        }
    }
}