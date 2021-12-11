using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        public static void Main(string[] args)
        {
            var user19338281 = new BankAccount("Edgars", (decimal)50000);
            var user19338282 = new BankAccount("Sragde", (decimal)-2);
            var user19338283 = new BankAccount("Degsra", (decimal)500000.50);
            var user19338284 = new BankAccount("Gderas", (decimal)0.00);
            Console.WriteLine(user19338281.ShowUserNameAndBalance());
            Console.WriteLine(user19338282.ShowUserNameAndBalance());
            Console.WriteLine(user19338283.ShowUserNameAndBalance());
            Console.WriteLine(user19338284.ShowUserNameAndBalance());
            Console.ReadKey();
        }
    }
}
