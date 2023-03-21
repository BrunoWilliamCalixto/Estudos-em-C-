using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobre_VetoresPt2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Entre com a quantidade de produtos a serem armazenados: ");
			int n = int.Parse(Console.ReadLine());

			Product[] vect = new Product[n];

			for(int i = 0; i < n; i++)
			{
				Console.Write("Entre com o nome do Produto: ");
				string nome = Console.ReadLine();

                Console.WriteLine("Entre com o preço do produto: ");
				double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

				vect[i] = new Product { Nome = nome, Preco = preco };	
				
			}

			double precoMedio = 0.0;
			for (int i = 0; i < n; i++)
			{
				precoMedio += vect[i].Preco;

			}

			precoMedio = precoMedio / n;

            Console.WriteLine("Preco Medio =  R$" + precoMedio.ToString("F2", CultureInfo.InvariantCulture));
        }
	}
}
