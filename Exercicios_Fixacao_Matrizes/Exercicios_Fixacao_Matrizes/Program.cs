using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Fixacao_Matrizes
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Entre com o numero de linhas: ");
			int n = int.Parse(Console.ReadLine());

			Console.Write("Entre com o numero de colunas: ");
			int m = int.Parse(Console.ReadLine());

			int[,] mat = new int[n, m];

			for (int i = 0; i < n; i++)
			{
				Console.WriteLine("Digite as propriedades da linha: " + i);
				string[] numbers = Console.ReadLine().Split(' ');

				for (int j = 0; j < m; j++)
				{
					mat[i, j] = int.Parse(numbers[j]);
				}
			}


			Console.WriteLine("--------------------------------------------------------------------------");

			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < m; j++)
				{
					Console.Write($"[{mat[i, j]}]");
				}
				Console.WriteLine();
			}

			Console.WriteLine("--------------------------------------------------------------------------");

			Console.WriteLine("Digite um numero para verificar sua posição: ");
			int numero = int.Parse(Console.ReadLine());

			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < m; j++)
				{
					if (mat[i, j] == numero)
					{
						Console.WriteLine("-----------------------------");
						Console.WriteLine($"posição: {i}, {j}");

						if (j > 0)
						{
							Console.WriteLine("Esquerda: " + mat[i, j - 1]);
						}
						if (i > 0)
						{
							Console.WriteLine("Cima: " + mat[i - 1, j]);
						}
						if (j < n - 1)
						{
							Console.WriteLine("Direita: " + mat[i, j + 1]);
						}
						if (i < m - 1)
						{
							Console.WriteLine("Abaixo: " + mat[i + 1, j]);
						}
					}
				}
			}
		}
	}
}

