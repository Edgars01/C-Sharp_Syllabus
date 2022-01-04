using System;

namespace Account
{
    class Program
    {
        private static void Main(string[] args)
        {
            var user19338281 = new Account("Matt's account", (decimal)1000);
            var user17347282 = new Account("My account", (decimal)0);
            user19338281.Withdrawal(100);
            user17347282.Deposit(100);
            Console.WriteLine(user19338281);
            Console.WriteLine(user17347282);

            var test1 = new Account("A", (decimal)100.0);
            var test2 = new Account("B", (decimal)0.0);
            var test3 = new Account("C", (decimal)0.0);

            Transfer(test1, test2, 50);

            Transfer(test1, test3, 25);

            Console.WriteLine(test1.ToString());
            Console.WriteLine(test2.ToString());
            Console.WriteLine(test3.ToString());
            Console.ReadKey();
        }
        public static void Transfer(Account from, Account to, decimal howMuch)
        {
            from.Withdrawal(howMuch);

            to.Deposit(howMuch);
        }
    }
}
