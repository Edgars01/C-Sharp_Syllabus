using System;
using Account.Expection;

namespace Account
{
    public class Account
    {
        private decimal _userAccountBalance;

        public Account(string userAccountName, decimal userAccountBalance)
        {
            if (userAccountName == null || userAccountBalance < 0) throw new NoDataProvidedException();

            Name = userAccountName;
            _userAccountBalance = userAccountBalance;
        }

        public decimal Withdrawal(decimal amountToWithdrawal)
        {
            return _userAccountBalance -= amountToWithdrawal;
        }

        public void Deposit(decimal amountToDeposit)
        {
            _userAccountBalance += amountToDeposit;
        }

        public decimal Balance()
        {
            return _userAccountBalance;
        }

        public string Name { get; set; }
    }
}
