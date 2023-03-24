using ExercicioResolvido1_ENUMS_COMPOSICAO.Entities;
using ExercicioResolvido1_ENUMS_COMPOSICAO.Entities.Enums;
using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioResolvido1_ENUMS_COMPOSICAO
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Enter department's name: "); //Entre com o nome do departamento
			string nameDepartment = Console.ReadLine();

			Console.WriteLine("Enter worker data: "); //Entre com os dados do funcionário
			Console.Write("Name: ");
			string nameWorker = Console.ReadLine();
			Console.Write("Level (Junior/MidLevel/Senior): ");
			string workLevel = Console.ReadLine();
			WorkerLevel level = (WorkerLevel)Enum.Parse(typeof(WorkerLevel), workLevel);
			Console.Write("Base Salary: ");
			double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			Worker worker = new Worker(nameWorker, level, baseSalary, new Department(nameDepartment));

			Console.Write("How many contracts to this worker? ");
			int numberContracts = int.Parse(Console.ReadLine());

			for (int i = 1; i <= numberContracts; i++)
			{
				Console.WriteLine("Enter #" + i + "contracts data:");
				Console.Write("Date (DD/MM/YYYY): ");
				DateTime date = DateTime.Parse(Console.ReadLine());
				Console.Write("Value per hour: ");
				double valuePerHour = double.Parse((string)Console.ReadLine());
				Console.Write("Duration (hours): ");
				int hours = int.Parse(Console.ReadLine());

				HourContract contract = new HourContract(date, valuePerHour, hours);
				worker.AddContract(contract);
                Console.WriteLine("-------------------------------------------------------");
            }

			Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
			string date1 = Console.ReadLine();

			int month = int.Parse(date1.Substring(0, 2));
			int year = int.Parse(date1.Substring(3));

            Console.WriteLine("Name: " + worker.Name);
			Console.WriteLine("Department: " + worker.Department.Name);
            Console.WriteLine("Income for: " + date1 + ": R$" + worker.Income(month, year));

        }
	}
}
