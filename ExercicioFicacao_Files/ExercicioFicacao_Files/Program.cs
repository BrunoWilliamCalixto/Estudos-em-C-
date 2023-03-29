using ExercicioFicacao_Files.Entities;
using System;
using System.Globalization; // Biblioteca para configuração de formatação de números
using System.IO;

namespace ExercicioFicacao_Files
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Digite o caminho completo do arquivo:"); // Solicita que o usuário informe o caminho completo do arquivo a ser lido
			string sourceFilePath = Console.ReadLine(); // Lê o caminho do arquivo informado pelo usuário

			try // Inicia o bloco try-catch para tratamento de exceções
			{
				string[] lines = File.ReadAllLines(sourceFilePath); // Lê todas as linhas do arquivo especificado pelo usuário e armazena em um vetor
				string sourceFolderPath = Path.GetDirectoryName(sourceFilePath); // Obtém o caminho da pasta onde está o arquivo a ser lido
				string targetFolderPath = sourceFolderPath + @"\out"; // Cria um caminho para a pasta de destino, com o nome "out", dentro da pasta do arquivo original
				string targetFilePath = targetFolderPath + @"\summary.csv"; // Cria o caminho do arquivo de destino "summary.csv", dentro da pasta "out"

				Directory.CreateDirectory(targetFolderPath); // Cria o diretório de destino "out", se ele não existir ainda

				using (StreamWriter sw = File.AppendText(targetFilePath)) // Abre o arquivo de destino "summary.csv" em modo de acrescentar dados, e cria um objeto StreamWriter para escrever nele
				{
					foreach (string line in lines) // Loop que percorre todas as linhas do arquivo (cada linha contém informações de um produto)
					{
						string[] fields = line.Split(','); // Divide a linha lida em campos separados por vírgula
						string name = fields[0]; // Lê o nome do produto
						double price = double.Parse(fields[1], CultureInfo.InvariantCulture); // Lê o preço do produto (como este número está em formato de ponto flutuante, é necessário informar que o separador decimal é o ponto, e não a vírgula, e por isso usamos a CultureInfo.InvariantCulture)
						int quantity = int.Parse(fields[2]); // Lê a quantidade do produto

						Product p = new Product(name, price, quantity); // Cria um objeto do tipo Product para realizar os cálculos necessários

						sw.WriteLine(p.Name + ", " + p.Total().ToString("F2", CultureInfo.InvariantCulture)); // Escreve no arquivo de destino o nome do produto e seu preço total calculado
					}
				}
			}
			catch (IOException e) // Caso ocorra alguma exceção na leitura ou escrita de arquivos, este bloco de código será executado
			{
				Console.WriteLine("Error: " + e.Message); // Exibe a mensagem de erro na tela
			}
		}
	}
}
