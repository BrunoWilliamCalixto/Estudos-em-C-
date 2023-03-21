using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace ExercicioFixacao_MembrosEstaticos
{
	internal class Program
	{
		static void Main(string[] args)
		{

			Console.Write("Qual é a cotação do dólar? ");
			double cotDolar = double.Parse(Console.ReadLine());

            Console.Write("Quantos dolares você");
			double dolares = double.Parse(Console.ReadLine());

			double conversao = ConversorDeMoeda.ConversaoDolarParaReal(cotDolar, dolares);

            Console.WriteLine("Conversao: " + conversao);

        }
	}
}
