using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
	static void Main(string[] args)
	{
		//DateTime d1 = DateTime.Now;
		//Console.WriteLine(d1);
		//      Console.WriteLine(d1.Ticks);

		// Exemplos de criação de objetos DateTime através dos construtores
		DateTime d2 = new DateTime(2018, 11, 25); // Data específica
		DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 03); // Data e hora específicas
		DateTime d4 = new DateTime(2018, 11, 25, 20, 45, 03, 500); // Data, hora e milissegundos específicos

		// Exemplos de criação de objetos DateTime através das structs
		DateTime d5 = DateTime.Now; // Data e hora atuais (local)
		DateTime d6 = DateTime.Today; // Data atual (local), hora 00:00:00
		DateTime d7 = DateTime.UtcNow; // Data e hora atuais (UTC)

		// Exibição dos objetos DateTime criados
		Console.WriteLine(d2);
		Console.WriteLine(d3);
		Console.WriteLine(d4);
		Console.WriteLine(d5);
		Console.WriteLine(d6);
		Console.WriteLine(d7);

		Console.WriteLine("------------------------------------");

		// Exemplos de conversão de strings em objetos DateTime
		DateTime d8 = DateTime.Parse("2000-08-15"); // Conversão de uma string no formato "yyyy-MM-dd" em um objeto DateTime
		DateTime d9 = DateTime.Parse("2000-08-15 14:06:55"); // Conversão de uma string no formato "yyyy-MM-dd HH:mm:ss" em um objeto DateTime

		string data = Console.ReadLine();
		DateTime d10 = DateTime.Parse(data); // Conversão de uma string


	}

}

