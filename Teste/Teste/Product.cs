using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFicacao_Files.Entities
{
	class Product
	{

		public string Name { get; set; }
		public double Price { get; set; }
		public int Quantity { get; set; }

		List<Product> list = new List<Product>();

		public Product(string name, double price, int quantity)
		{
			Name = name;
			Price = price;
			Quantity = quantity;
			list = new List<Product>();
		}

		public void AddProduct(Product product, List<Product> list)
		{
			list.Add(product);
		}

		public void RemoveProduct(Product product, List<Product> list)
		{
			list.Remove(product);
		}

		public double Total()
		{
			return Price * Quantity;
		}

		public override string ToString()
		{
			return $"Nome: {Name}, preço: R${Price.ToString("F2", CultureInfo.InvariantCulture)}, quantidade: {Quantity}";
		}
	}
}