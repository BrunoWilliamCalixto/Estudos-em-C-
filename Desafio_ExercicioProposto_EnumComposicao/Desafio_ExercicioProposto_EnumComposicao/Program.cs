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

			// Cria uma instância do objeto Client com os dados informados
			Client client = new Client(name, email, birthDate);

			// Solicita os dados do pedido
			Console.Write("Enter order data: ");
			string orderStatus = Console.ReadLine();

			// Converte a string informada em um valor do tipo OrderStatus usando o método Enum.Parse
			OrderStatus status = (OrderStatus)Enum.Parse(typeof(OrderStatus), orderStatus);

			// Cria uma instância do objeto Order com a data atual, o status e o objeto Client criado anteriormente
			DateTime dateNow = DateTime.Now;
			Order order = new Order(dateNow, status, client);

			// Solicita a quantidade de itens do pedido
			Console.Write("How many items to this order? ");
			int numberItems = int.Parse(Console.ReadLine());

			// Loop para solicitar os dados de cada item e adicionar ao objeto Order
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

				// Cria uma instância do objeto OrderItem com os dados informados e adiciona ao objeto Order
				OrderItem item = new OrderItem(quantity, new Product(productName, productPrice));
				order.AddItem(item);
			}

			// Imprime na tela um resumo do pedido
			Console.WriteLine();
			Console.WriteLine("----------------------------------------------");
			Console.WriteLine("ORDER SUMARY: ");
			Console.WriteLine(order);
		}
	}
}
