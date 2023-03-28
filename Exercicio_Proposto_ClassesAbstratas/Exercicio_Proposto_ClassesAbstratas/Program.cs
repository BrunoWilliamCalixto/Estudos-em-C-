using Exercicio_Proposto_ClassesAbstratas.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Proposto_ClassesAbstratas
{
	internal class Program
	{
		static void Main(string[] args)
		{

			List<Pessoa>list = new List<Pessoa>();

			Console.Write("Enter the number of tax payers: ");
			int n = int.Parse(Console.ReadLine());

			for(int i = 1; i <= n; i++)
			{
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company (i/c)? ");
				string option = Console.ReadLine().ToLower().Substring(0,1);
                Console.Write("Name: ");
				string name = Console.ReadLine();
                Console.Write("Anual Income: ");
				double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

				if(option == "i")
				{
                    Console.Write("Health expenditures: ");
					double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
					Pessoa pF = new PessoaFisica(name, anualIncome, healthExpenditures);
					list.Add(pF);
                }

				if(option == "c")
				{
					Console.Write("Number of employees: ");
					int employees = int.Parse(Console.ReadLine());
					Pessoa pJ = new PessoaJuridica(name, anualIncome, employees);
					list.Add(pJ);
				}

			}
            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");

			foreach(Pessoa pessoa in list)
			{
                Console.WriteLine($"{pessoa.Nome}: $ {pessoa.CalculaImposto().ToString("F2", CultureInfo.InvariantCulture)}");
            }

			Console.WriteLine();
			double totalTaxes = 0.0;
			foreach (Pessoa pessoa in list)
			{
				totalTaxes += pessoa.CalculaImposto();
			}

			Console.WriteLine($"TOTAL TAXES: $ {totalTaxes.ToString("F2", CultureInfo.InvariantCulture)}");
		}
	}
}
