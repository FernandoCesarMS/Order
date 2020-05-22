using Pedido.Entities;
using Pedido.Entities.Enums;
using System;

namespace Pedido
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Order order = new Order(DateTime.Now,status);
            Console.Write("How many items to this order? ");
            int items = int.Parse(Console.ReadLine());
            for (int i = 1; i <= items; i++)
            {
                Console.WriteLine("Enter #{0} item data:",i);
                Console.Write("Product name: ");
                string nameProduct = Console.ReadLine();
                Console.Write("Product price: ");
                double priceProduct = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                Product product = new Product(nameProduct,priceProduct);
                OrderItem orderItem = new OrderItem(quantity,priceProduct,product);
            }
            Console.WriteLine(order);
        }
    }
}
