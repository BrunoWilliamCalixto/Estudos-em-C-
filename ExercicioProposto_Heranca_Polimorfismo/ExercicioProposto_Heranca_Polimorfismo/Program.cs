using ExercicioProposto_Heranca_Polimorfismo.Entities;
using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioProposto_Heranca_Polimorfismo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<Product> list = new List<Product>();
			Console.Write("Enter the number of products: ");
			int n = int.Parse(Console.ReadLine());

			for(int i = 0; i < n; i++)
			{
				string option;
				Console.Write($"Product #{i + 1} data: ");
				while (true)
				{
                    Console.Write("Common, used or imported? (c/u/i): ");
					option = Console.ReadLine().ToLower().Substring(0, 1);

					if(option != "c" && option != "i" && option != "u")
					{
                        Console.WriteLine("Opção inválida, tente novamente!");
						continue;
                    }

					break;
                }
				Console.Write("Name: ");
				string nameProduct = Console.ReadLine();
                Console.Write("Price: ");
				double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

				if(option == "i")
				{
                    Console.Write("Customs fee: ");
					double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

					Product productImported = new ImportedProduct(nameProduct, price, customsFee);
					list.Add(productImported);
                }


				else if(option == "u")
				{
					Console.Write("Manufacture date (DD/MM/YYYY): ");
					DateTime manufactureDate = DateTime.Parse(Console.ReadLine());

					Product productUsed = new UsedProduct(nameProduct, price, manufactureDate);
					list.Add(productUsed);
				}
				else
				{
					Product product = new Product(nameProduct, price);
					list.Add(product);
				}
			}

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
			foreach(Product product in list)
			{
				Console.WriteLine(product.PriceTag());
			}

        }
	}
}
