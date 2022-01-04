using System;

namespace Exercise_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter annual interest rate:");
            double anIntRate = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter starting balance:");
            double startBal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("How long has the account been opened?");
            int monthsActive = Convert.ToInt32(Console.ReadLine());

            SavingsAccount acc01 = new SavingsAccount(startBal, anIntRate);

            for (int i = 1; i <= monthsActive; i++)
            {
                Console.WriteLine($"Enter amount deposited for month {i}:");
                acc01.Deposit(Convert.ToDouble(Console.ReadLine()));

                Console.WriteLine($"Enter amount withdrawn for {i}:");
                acc01.Withdrawal(Convert.ToDouble(Console.ReadLine()));
            }
            Console.WriteLine($"Ending balance: {acc01._balance}\n Total deposited: {acc01._totalDeposit}\n");
            Console.WriteLine($"Total withdrawn: {acc01._totalWithdrawal}\nInterest earned: {acc01._totalMonthlyInterest}");
            Console.ReadLine();
        }
    }
}
