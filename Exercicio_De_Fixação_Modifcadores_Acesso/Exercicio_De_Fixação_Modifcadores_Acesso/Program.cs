using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_De_Fixação_Modifcadores_Acesso
{
	internal class Program
	{
		static void Main(string[] args)
		{
			ContaBancaria conta;

			while (true)
			{
				string name;
				int numberAccount;
				double valueInicial = 0.0;



				Console.Write("Entre com o número da conta: ");
				numberAccount = int.Parse(Console.ReadLine());

				Console.Write("Titular da conta: ");
				name = Console.ReadLine();

				Console.Write("Haverá depósito inicial (s/n)? ");
				char depositInicial = char.Parse(Console.ReadLine());


				if (depositInicial == 's' || depositInicial == 'S')
				{
					Console.Write("Entre com o valor inicial: ");
					valueInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
					conta = new ContaBancaria(name, numberAccount, valueInicial);
				}

				else if (depositInicial == 'n' || depositInicial == 'N')
				{
					conta = new ContaBancaria(name, numberAccount);
				}
				else
				{
					Console.WriteLine("Valor inválido, tente novamente");
					continue;
				}

				
				Console.WriteLine("------------------------------------------------------------------------");
				Console.WriteLine("Dados da conta:");
                Console.WriteLine(conta);

                Console.Write("Entre com o valor para depósito: ");
				double valueDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
				conta.Depositar(valueDeposito);
				Console.WriteLine("------------------------------------------------------------------------");
				Console.WriteLine("Dados da conta atualizados:");
				Console.WriteLine(conta);

				Console.Write("Entre com o valor para Sacar: ");
				double valueSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
				conta.Sacar(valueSaque);
                Console.WriteLine("------------------------------------------------------------------------");
                Console.WriteLine("Dados da conta atualizados:");
				Console.WriteLine(conta);

				break;
			}






		}
	}
}
