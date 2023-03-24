using Exercicios_Fixacao_Listas;
using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
	static void Main(string[] args)
	{
		int id = 0;
		string nome = "";
		double salario = 0.0;

		// Pergunta ao usuário quantos funcionários serão registrados
		Console.Write("Quantos Funcionarios serão registrados? ");
		int n = int.Parse(Console.ReadLine());

		// Cria uma lista para armazenar os funcionários registrados
		List<Funcionario> list = new List<Funcionario>();

		// Loop para registrar cada funcionário
		for (int i = 0; i < n; i++)
		{
			Console.WriteLine("Funcionario #" + (i + 1));

			// Loop para garantir que cada ID seja único
			do
			{
				Console.Write("Id: ");
				id = int.Parse(Console.ReadLine());

				// Verifica se o ID já existe na lista
				if (ExisteId(list, id))
				{
					Console.WriteLine("ID já existente");
					Console.WriteLine("----------------------------------------");
					continue;
				}
				else
				{
					break;
				}
			} while (true);

			Console.Write("Nome: ");
			nome = Console.ReadLine();

			Console.Write("Salario: R$");
			salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			// Adiciona um novo funcionário na lista
			list.Add(new Funcionario(id, nome, salario));
		}

		Console.WriteLine("----------------------------------------");
		Console.WriteLine("Funcionarios Registrados");

		// Imprime a lista de funcionários registrados
		foreach (Funcionario funcionario1 in list)
		{
			Console.WriteLine(funcionario1);
		}

		// Solicita ao usuário o ID do funcionário para atualizar o salário
		Console.Write("Entre com o Id para acrescentar o salario: ");
		int idFuncionario = int.Parse(Console.ReadLine());

		// Busca o funcionário pelo ID
		Funcionario funcionario = list.Find(x => x.Id == idFuncionario);

		if (funcionario != null)
		{
			Console.WriteLine("----------------------------------------");
			Console.WriteLine("Qual a porcentagem de aumento? ");

			// Solicita ao usuário a porcentagem de aumento do salário
			double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			// Atualiza o salário do funcionário
			funcionario.AumentarSalario(porcentagem);
		}
		else
		{
			Console.WriteLine("Id não existe");
		}

		Console.WriteLine("----------------------------------------");
		Console.WriteLine("Lista atualizada de Funcionarios");

		// Imprime a lista atualizada de funcionários
		foreach (Funcionario funcionario1 in list)
		{
			Console.WriteLine(funcionario1);
		}
	}

	// Função que verifica se um ID já existe na lista de funcionários
	private static bool ExisteId(List<Funcionario> list, int id)
	{
		foreach (Funcionario funcionario in list)
		{
			if (funcionario.Id == id)
			{
				return true;
			}
		}
		return false;
	}
}
