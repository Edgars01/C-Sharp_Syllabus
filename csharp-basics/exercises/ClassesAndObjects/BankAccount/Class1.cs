using System;


namespace BankAccount
{
    public class BankAccount
    {
        public string _userAccountName;
        public decimal _userAccountBalance;
        public string _UserInformation;

        public BankAccount(string userAccountName, decimal userAccountBalance)
        {
            _userAccountName = userAccountName;
            _userAccountBalance = userAccountBalance;
        }

        private void FormatUserInformation()
        {
            var formatedMoey = $"{_userAccountBalance:0.00}";
            _UserInformation = $"{_userAccountName}, ${formatedMoey}";
        }

        public string ShowUserNameAndBalance()
        {
            FormatUserInformation();
            if (_userAccountBalance < 0)
            {
                _UserInformation = _UserInformation.Replace(" $ ", "-$");
            }
            return _UserInformation;
        }
    }
}
