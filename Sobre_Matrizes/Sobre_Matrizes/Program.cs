using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobre_Matrizes
{
	internal class Program
	{
		static void Main(string[] args)
        {
            double[,] mat1 = new double[2,2];

            //Console.WriteLine(mat1.Length); // Pega a quantidade total do tamanho de linhas e colunas
            //Console.WriteLine(mat1.Rank); //pega a quantidade de linhas
            //Console.WriteLine(mat1.GetLength(0));//Pega a propriedade dimensional da linha
            //Console.WriteLine(mat1.GetLength(1)); // pega a quantidade dimensional da coluna


            Console.Write("Digite um numero para criar linhas e colunas: ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n,n];

            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
               
                for (int j = 0; j < n; j++)
                {
                    mat[i,j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Diagonal principal");
            for (int i = 0; i < n; i++)
			{
                Console.Write($"{mat[i,i]} ");
            }

            int numerosNegativos = 0;

			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
                    if (mat[i,j] < 0)
                    {
                        numerosNegativos++;
                    }
				}
			}

            Console.WriteLine("Numeros negativos: " + numerosNegativos);
        }
    }
}
