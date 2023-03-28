using Exercicios_Fixacacao_TryCatch.Entities;
using Exercicios_Fixacacao_TryCatch.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Fixacacao_TryCatch
{
	internal class Program
	{
		static void Main(string[] args)
		{
			try
			{
				Console.WriteLine("Entre com os dados da conta: ");
				Console.Write("Numero: ");
				int numero = int.Parse(Console.ReadLine());
				Console.Write("Titular: ");
				string titular = Console.ReadLine();
				Console.Write("Saldo inicial: ");
				double saldoInicial = double.Parse(Console.ReadLine());
				Console.Write("Limite de saque: ");
				double limiteSque = double.Parse(Console.ReadLine());

				Account acc = new Account(numero, titular, saldoInicial, limiteSque);

				//...
				Console.Write("Entre com a quantia para saque:");
				double saque = double.Parse(Console.ReadLine());

				acc.Withdraw(saque);
				Console.WriteLine("Novo saldo: " + acc.Balance);


                Console.Write("Deseja realizar um depósito (s/n)?");
				char opcao = char.Parse(Console.ReadLine());
				
				if(opcao == 's')
				{
					Console.Write("Digite o valor (max. R$1000): ");
					double deposito = double.Parse(Console.ReadLine());
					acc.Deposit(deposito);
					Console.WriteLine("Novo saldo: " + acc.Balance);
				}

			}
			catch(DomainException e)
			{
				Console.WriteLine("Erro de Saque: " + e.Message);
			}
			catch(Exception e)
			{
                Console.WriteLine("Erro inesperado: " + e.Message);
            }
		}
	}
}
