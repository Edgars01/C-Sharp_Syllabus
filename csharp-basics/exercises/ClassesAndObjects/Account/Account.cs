namespace Account
{
    public class Account
    {
        private string _userAccountName;
        private decimal _userAccountBalance;

        public Account(string userAccountName, decimal userAccountBalance)
        {
            _userAccountName = userAccountName;
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

        public override string ToString()
        {
            return $"{_userAccountName}: {_userAccountBalance}";
        }

        public string Name
        {
            get => _userAccountName;
            set => _userAccountName = value;
        }
    }
}
