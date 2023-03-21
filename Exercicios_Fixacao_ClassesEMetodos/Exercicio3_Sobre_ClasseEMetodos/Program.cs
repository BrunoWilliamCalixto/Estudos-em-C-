using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3_Sobre_ClasseEMetodos
{
	internal class Program
	{
		static void Main(string[] args)
		{

			Aluno aluno = new Aluno();


            Console.WriteLine("Digite o nome do aluno");
			aluno.Nome = Console.ReadLine();	

            while (true)
			{
                Console.WriteLine("--------------------------------------------------------");
                Console.Write("Digite a nota do primeiro trimestre: ");
				aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
				if (aluno.Nota1 > 30)
				{
					Console.WriteLine("Nota Inválida!");
					continue;
				}

				Console.Write("Digite a nota do segundo trimestre: ");
				aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
				if (aluno.Nota2 > 35)
				{
					Console.WriteLine("Nota Inválida!");
					continue;
				}

				Console.Write("Digite a nota do terceiro trimestre: ");
				aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
				if (aluno.Nota2 > 35)
				{
					Console.WriteLine("Nota Inválida!");
					continue;
				}
				break;
			}
			Console.WriteLine("--------------------------------------------------------");
			Console.WriteLine(aluno);



        }
	}
}
