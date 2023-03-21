using Course;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
	static void Main(string[] args)
	{
		Produto p = new Produto("TV", 900.00, 10);

		p.Nome = "TV LCD";

		int quantidade = 25;

		p.AdicionarProdutos(quantidade);

        Console.WriteLine(p.Nome);
        Console.WriteLine(p.Quantidade);


    }
}

