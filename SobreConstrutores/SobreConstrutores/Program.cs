using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreConstrutores
{
	internal class Program
	{
		static void Main(string[] args)
		{

			Produto p = new Produto("TV", 500.00, 10);

			Console.WriteLine("Alteração do nome: " );
			p.SetNome(Console.ReadLine());


			Console.WriteLine(p.GetNome());
			Console.WriteLine(p.GetPreco().ToString("F2", CultureInfo.InvariantCulture));

			int quantidade = 10;
			p.AdicionarProdutos(quantidade);

			Console.WriteLine(p);

		}
	}
}
