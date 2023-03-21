using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Fixacao_ClassesEMetodos
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Funcionario f1 = new Funcionario();	

            Console.Write("Nome: ");
			f1.Nome = Console.ReadLine();

			Console.Write("Salário bruto: ");
			f1.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			Console.Write("Imposto: ");
			f1.Imposto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionario: " + f1 );

			Console.WriteLine("Digite a porcentagem para aumentar o salário: ");
			double porcentagem = double.Parse(Console.ReadLine());
			f1.AumentarSalario(porcentagem);

			Console.WriteLine("Dados atualizados: " + f1);
        }
	}
}
