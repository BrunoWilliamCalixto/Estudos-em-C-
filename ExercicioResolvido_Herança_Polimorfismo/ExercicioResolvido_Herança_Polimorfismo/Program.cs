using ExercicioResolvido_Herança_Polimorfismo.Entities;
using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioResolvido_Herança_Polimorfismo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<Employee> list = new List<Employee>();	

            
			Console.Write("Enter the number of employees: ");
			int nEmployees = int.Parse(Console.ReadLine());
			
			for (int i = 0; i < nEmployees; i++)
			{
				Console.WriteLine("Employee #" + (i + 1) + " data");
				char ch = ' ';
				while (true)
				{
					Console.Write("Outsorced (y/n)? ");
					ch = char.Parse(Console.ReadLine().ToLower());
					if (ch != 'y' && ch != 'n')
					{
                        Console.WriteLine("Comando inválido, tente novamente");
						continue;
                    }
					break;
				}


				Console.Write("Name: ");
				string name = Console.ReadLine();
				Console.Write("Hours: ");
				int hours = int.Parse(Console.ReadLine());
				Console.Write("Value per hour: ");
				double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

				if (ch == 'n')
				{
					Employee emp = new Employee(name, hours, valuePerHour);
					list.Add(emp);
				}

				else if (ch == 'y')
				{
					Console.Write("Additional charge: ");
					double additionalChargeChange = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
					Employee outEmp = new OutSourcedEmployee(name, hours, valuePerHour, additionalChargeChange);
					list.Add(outEmp);
				}
	
			}
				
			

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("PAYMENTS: ");

            foreach (Employee emp in list)
            {
                Console.WriteLine(emp.Name + " - R$" + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
		}
	}
}
