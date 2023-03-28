using System;
using System.IO;

namespace Sobre_File_FileInfo_IOException
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Define os caminhos dos arquivos de entrada e saída
			string sourcePath = @"C:\Users\nobru\Pictures\temp\file1.txt";
			string targetPath = @"C:\Users\nobru\Pictures\temp\file2.txt";

			try
			{
				// Instancia um objeto FileInfo para o arquivo de entrada
				FileInfo fileInfo = new FileInfo(sourcePath);

				// Copia o arquivo de entrada para o arquivo de saída
				fileInfo.CopyTo(targetPath, true);

				// Lê todas as linhas do arquivo de entrada e armazena em um vetor
				string[] lines = File.ReadAllLines(sourcePath);

				// Imprime cada linha do arquivo na tela
				foreach (string line in lines)
				{
					Console.WriteLine(line);
				}
			}
			catch (IOException e)
			{
				// Imprime mensagem de erro em caso de exceção
				Console.WriteLine("Ocorreu um erro: " + e.Message);
			}
		}
	}
}

//Nesse exemplo, o programa utiliza a classe FileInfo para obter informações sobre o arquivo de entrada, como por exemplo o tamanho do arquivo, a data de criação, entre outras.
//Além disso, o programa utiliza o método CopyTo para copiar o arquivo de entrada para o arquivo de saída. Para a leitura do arquivo de entrada, é utilizado o método ReadAllLines da classe File,
//que lê todas as linhas do arquivo e as armazena em um vetor de strings.
//O programa também utiliza um bloco try-catch para capturar exceções do tipo IOException, que podem ser geradas em caso de problemas na leitura ou escrita de arquivos.