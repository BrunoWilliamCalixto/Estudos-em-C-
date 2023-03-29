using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobre_FileStream_StreamReader
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Define o caminho do arquivo que será lido
			string path = @"C:\Users\nobru\Pictures\temp\file1.txt";

			// Declara um objeto StreamReader e atribui null como valor inicial
			StreamReader sr = null;

			try
			{
				// Abre o arquivo no modo de leitura e cria um novo objeto StreamReader
				// O parâmetro 'path' especifica o arquivo a ser lido
				sr = File.OpenText(path);

				// Enquanto o fim do arquivo não for alcançado
				while (!sr.EndOfStream)
				{
					// Lê uma linha do arquivo e a armazena na variável 'line'
					string line = sr.ReadLine();

					// Escreve a linha lida no console
					Console.WriteLine(line);
				}
			}
			catch (IOException e)
			{
				// Se ocorrer um erro de entrada ou saída durante a leitura do arquivo, a exceção será capturada e tratada aqui
				Console.WriteLine("Error: " + e.Message);
			}
			finally
			{
				// Certifica-se de que o objeto StreamReader seja fechado, mesmo se ocorrer um erro durante a leitura do arquivo
				if (sr != null) sr.Close();
			}
		}
	}
}