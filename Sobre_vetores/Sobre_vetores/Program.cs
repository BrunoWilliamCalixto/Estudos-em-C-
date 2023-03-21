using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobre_vetores
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Quantos números gostaria de armazenar em um vetor? ");
			int n = int.Parse(Console.ReadLine());

			double[] vect = new double[n];
			double resultado = 0.0;

			for(int i= 0; i < vect.Length; i++)
			{
				Console.Write("Digite a " + (i + 1) + "° altura: ");
				vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
				resultado += vect[i];
			}

			resultado = resultado / n;

            Console.WriteLine("Media de altura: " +  resultado.ToString("F2", CultureInfo.InvariantCulture));

			for (int i = 0; i < vect.Length; i++)
			{
                Console.WriteLine("Posicão " + i + $"[{vect[i]}]");
            }

			Console.WriteLine("Agora digite o numero do vetor para ser acessado: " + vect.Length + " vetores no total");
			int posicao = int.Parse(Console.ReadLine());

            if (posicao < vect.Length)
			{
				Console.WriteLine("Você puxou a altura: " + vect[posicao]);
			}
			else
			{
                Console.WriteLine("Operação inválida");
            }
        }
	}
}
