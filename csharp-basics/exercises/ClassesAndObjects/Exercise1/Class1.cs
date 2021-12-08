using System;

namespace Exercise1
{
    public class Class1
    {
        static void Main(string[] args)
        {
            Product product1 = new Product("Logitech mouse", 70.00, 14);
            Product product2 = new Product("iPhone 5s", 999.99, 3);
            Product product3 = new Product("Epson EB-U05", 440.46, 1);

            Console.WriteLine(product1.PrintProduct());
            Console.WriteLine(product2.PrintProduct());
            Console.WriteLine(product3.PrintProduct());

            product1.changePrice(3);
            product1.changeQuantity(50);
            Console.WriteLine(product1.PrintProduct());

            Console.ReadLine();
        }
    }
}
