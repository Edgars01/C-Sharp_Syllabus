using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_8
{
    public class SavingsAccount
    {
        public double _startingBalance;
        public double _withdrawal;
        public double _deposit;
        public double _balance;
        public double _totalWithdrawal;
        public double _totalDeposit;
        public double _totalMonthlyInterest;
        public double _annualInterestRate;

        public SavingsAccount(double balance, double annualInterestRate)
        {
            _balance = balance;
            _annualInterestRate = annualInterestRate;
        }

        public void Withdrawal(double userAmount)
        {
            _balance -= userAmount;
            _totalWithdrawal += userAmount;
        }

        public void Deposit(double userAmount)
        {
            _balance += userAmount;
            _totalDeposit += userAmount;
        }

        public void MonthlyInterest(double annualInterestRate)
        {
            var monthlyIntrest = annualInterestRate / 12 * _balance;
            _balance += monthlyIntrest;
            _totalMonthlyInterest += monthlyIntrest;
        }
    }
}
