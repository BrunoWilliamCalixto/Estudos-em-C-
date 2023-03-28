using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobre_StreamWriter
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string sourcePath = @"C:\Users\nobru\Pictures\temp\file1.txt";
			string targetPath = @"C:\Users\nobru\Pictures\temp\file2.txt";

			try
			{
				// Lê todas as linhas do arquivo de origem e armazena em um array de strings
				string[] lines = File.ReadAllLines(sourcePath);

				// Cria um StreamWriter para o arquivo de destino, anexando ao final do arquivo se ele já existir
				using (StreamWriter sw = File.AppendText(targetPath))
				{
					// Itera por todas as linhas lidas do arquivo de origem
					foreach (string line in lines)
					{
						// Escreve cada linha em letras maiúsculas no arquivo de destino
						sw.WriteLine(line.ToUpper());
					}
				}
			}
			catch (IOException e)
			{
                Console.WriteLine("Error: " + e.Message);
            }
		}
	}
}
