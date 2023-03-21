using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResolvendoSegundoProblema_SobreClasses_Metodos
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Produto p1 = new Produto();

            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
			p1.Nome = Console.ReadLine();

			Console.Write("Preço: ");
			p1.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade no estoque: ");
			p1.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do Produto: " + p1);

            Console.Write("Digite o numero de produtos a ser adicionado ao estoque: ");
            int AddQuantity = int.Parse(Console.ReadLine());
			p1.AdicionarProdutos(AddQuantity);

			Console.WriteLine("Dados Atualizados: " + p1);

			Console.Write("Digite o numero de produtos a ser removido do estoque: ");
			int RemoveQuantity = int.Parse(Console.ReadLine());
			p1.RemoverProdutos(RemoveQuantity);

			Console.WriteLine("Dados Atualizados: " + p1);


		}
	}
}
