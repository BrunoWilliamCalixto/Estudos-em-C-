using ExercicioFicacao_Files.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

class Program
{
	static void Main(string[] args)
	{
		// Cria uma lista de produtos
		List<Product> list = new List<Product>();

		// Repete enquanto o usuário desejar adicionar mais produtos
		while (true)
		{
			// Solicita os dados do produto
			Console.WriteLine("Entre os dados:");
			Console.Write("Nome: ");
			string nome = Console.ReadLine();

			Console.Write("Preço: ");
			double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			Console.Write("Quantidade: ");
			int quantidade = int.Parse(Console.ReadLine());

			// Adiciona o produto à lista de produtos
			list.Add(new Product(nome, preco, quantidade));

			// Exibe o produto na tela
			Console.WriteLine(list[list.Count - 1]);

			// Pergunta ao usuário se deseja continuar a adicionar produtos
			Console.Write("Deseja continuar? s/n: ");
			char option = char.Parse(Console.ReadLine());

			if (option == 'n')
			{
				break;
			}
			else if (option != 's')
			{
				Console.WriteLine("Comando inválido");
			}
		}

		string outputFilePath = @"C:\Users\nobru\Pictures\temp\product.txt";
		WriteProductsToFile(list, outputFilePath);

		string targetFilePath = @"C:\Users\nobru\Pictures\temp\out\sumProducts.csv";
		CalculateTotalForEachProduct(outputFilePath, targetFilePath);

		RemoveProductFromFile(targetFilePath);
	}

	// Escreve os dados dos produtos em um arquivo de texto
	static void WriteProductsToFile(List<Product> products, string outputFilePath)
	{
		string productData;
		foreach (Product p in products)
		{
			productData = $"{p.Name}, {p.Price.ToString("F2", CultureInfo.InvariantCulture)}, {p.Quantity}";

			// Abre o arquivo de saída em modo de acréscimo (append) e escreve os dados do produto nele
			using (StreamWriter writer = File.AppendText(outputFilePath))
			{
				writer.WriteLine(productData);
			}
		}
	}

	// Calcula o total de cada produto e escreve os dados em um arquivo CSV
	static void CalculateTotalForEachProduct(string sourceFilePath, string targetFilePath)
	{
		try
		{
			// Lê as linhas do arquivo de entrada
			string[] lines = File.ReadAllLines(sourceFilePath);

			// Cria a pasta de saída caso ela ainda não exista
			string targetFolderPath = Path.GetDirectoryName(targetFilePath);
			Directory.CreateDirectory(targetFolderPath);

			// Abre o arquivo de saída em modo de acréscimo (append) e escreve os dados de cada produto e seu total nele
			using (StreamWriter sw = File.AppendText(targetFilePath))
			{
				foreach (string line in lines)
				{
					// Divide a linha em campos separados por vírgula
					string[] fields = line.Split(',');

					// Extrai os valores dos campos
					string name = fields[0];
					double value = double.Parse(fields[1]);
					int quantity = int.Parse(fields[2]);

					// Cria um objeto Produto com os valores extraídos dos campos
					Product p = new Product(name, value, quantity);

					// Escreve os dados do produto e seu total no arquivo de saída
					sw.WriteLine(p.Name + "," + p.Total().ToString("F2", CultureInfo.InvariantCulture));
				}
			}
		}
		catch (IOException e)
		{
			Console.WriteLine("Error: " + e.Message);
		}


	}

	static void RemoveProductFromFile(string filePath)
	{
		// Lê todas as linhas do arquivo e armazena em uma lista
		List<string> lines = File.ReadAllLines(filePath).ToList();

		// Exibe a lista de produtos para que o usuário possa escolher qual deseja remover
		Console.WriteLine("Produtos disponíveis:");
		for (int i = 0; i < lines.Count; i++)
		{
			Console.WriteLine($"{i}: {lines[i]}");
		}

		// Solicita ao usuário o índice do produto a ser removido
		Console.Write("Digite o índice do produto a ser removido: ");
		int index = int.Parse(Console.ReadLine());

		// Remove o produto da lista
		lines.RemoveAt(index);

		// Reescreve o arquivo com as linhas atualizadas
		File.WriteAllLines(filePath, lines);
		Console.WriteLine("Produto removido com sucesso.");
	}
}