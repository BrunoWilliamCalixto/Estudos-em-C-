using Program;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_FixacaoVetores
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Cliente[] cliente = new Cliente[10];
			int numeroQuarto;
			string email;
			string nome;


			Console.Write("Digite o número de estudantes a serem registrados: ");
			int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
			{
				Console.WriteLine("Dados do " + (i+1) + "° estudante");

                Console.Write("Digite o nome: ");
				nome = Console.ReadLine();

                Console.Write("Digite o email: ");
				email = Console.ReadLine();

                Console.Write("Digite o quarto escolhido (0 - 9):  ");
				numeroQuarto = int.Parse(Console.ReadLine());

				cliente[numeroQuarto] = new Cliente {Nome = nome, Email = email, Quarto = numeroQuarto};
				Console.WriteLine("--------------------------------------------------------------");
                Console.WriteLine();


            }


            Console.WriteLine("Dados do Cliente e quartos ocupados: ");
            for (int i = 0;i < cliente.Length;i++)
			{
				if (cliente[i] != null)
				{ 
					Console.WriteLine(cliente[i]);
					Console.WriteLine();
				}
				
			}

		}
	}
}
