using System; // Importa o namespace System
using System.IO; // Importa o namespace System.IO


namespace Bloco_using // Declaração do namespace "Bloco_using"
{
	internal class Program // Declaração da classe interna "Program"
	{
		static void Main(string[] args) // Método "Main" é o ponto de entrada do programa
		{
			string path = @"C:\Users\nobru\Pictures\temp\file1.txt"; // Declaração da string "path" que contém o caminho do arquivo de texto que será lido pelo programa

			try // Início de um bloco try-catch para lidar com possíveis exceções durante a execução do programa
			{
				using (StreamReader sr = File.OpenText(path)) // A instrução "using" é usada para garantir que os recursos do objeto "StreamReader" sejam liberados após o término do uso. A classe "StreamReader" é responsável por ler o conteúdo do arquivo de texto.
				{
					while (!sr.EndOfStream) // Dentro do bloco "using", há um loop while que executa até que o final do arquivo seja alcançado, determinado pelo método "EndOfStream" da classe "StreamReader".
					{
						string line = sr.ReadLine(); // Em cada iteração do loop, é lida uma linha do arquivo de texto usando o método "ReadLine" da classe "StreamReader".
						Console.WriteLine(line); // A linha lida é imprimida no console usando o método "WriteLine" da classe "Console".
					}
				}

			}
			catch (IOException e) // O bloco "try-catch" trata possíveis exceções durante a execução do programa, onde se for lançada uma exceção do tipo "IOException", a mensagem de erro é exibida no console.
			{
				Console.WriteLine("Error: " + e.Message); // A mensagem de erro é exibida no console usando o método "WriteLine" da classe "Console".
			}
		} }
	}
}
