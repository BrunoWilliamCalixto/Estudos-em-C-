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
			string path = @"C:\Users\nobru\Pictures\temp\file1.txt";
			StreamReader sr = null;

			try
			{
				sr = File.OpenText(path); // Ao instanciar o StreamReader com parametro fs, conseguimos instanciar a leitura de nosso arquivo, a partir do File Mode Open
				while (!sr.EndOfStream) // Enquanto não ler o arquivo até o fim
				{
					string line = sr.ReadLine();
					Console.WriteLine(line);
				}
            }
			catch (IOException e)
			{
                Console.WriteLine("Error: " + e.Message);
            }
			finally
			{
				if (sr != null) sr.Close();
			}
		}
	}
}
