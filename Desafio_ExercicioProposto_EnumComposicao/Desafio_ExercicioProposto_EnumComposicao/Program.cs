using Desafio_ExercicioProposto_EnumComposicao.Entities;
using Desafio_ExercicioProposto_EnumComposicao.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_ExercicioProposto_EnumComposicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");

            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Enter birth date(DD/MM/YYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, birthDate);

            Console.Write("Enter order data: ");
            string orderStatus = Console.ReadLine();
            OrderStatus status = (OrderStatus)Enum.Parse(typeof(OrderStatus), orderStatus);

            
            DateTime dateNow = DateTime.Now;
            Order order = new Order(dateNow, status, client);

            Console.Write("How many items to this order? ");
            int numberItems = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberItems; i++)
            {
                Console.WriteLine("Enter #" + i + " item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                Console.WriteLine();


                OrderItem item = new OrderItem(quantity, new Product(productName, productPrice));
                order.AddItem(item);

            }

            Console.WriteLine();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("ORDER SUMARY: ");
            Console.WriteLine(order);
        }
    }
}
