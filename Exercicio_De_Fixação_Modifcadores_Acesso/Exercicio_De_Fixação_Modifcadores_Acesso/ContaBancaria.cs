using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_De_Fixação_Modifcadores_Acesso
{
	internal class ContaBancaria
	{
		private string _nome;
		public int NumeroConta { get; private set; }
		public double Saldo { get; private set; }


		public ContaBancaria()
		{
		}

		public ContaBancaria(string nome, int numeroConta)
		{
			_nome = nome;
			NumeroConta = numeroConta;
		}

		public ContaBancaria(string nome, int numeroConta, double depositoInicial) : this(nome, numeroConta)
		{
			Depositar(depositoInicial);
		}


		public string Nome
		{
			get { return _nome; }
			set
			{
				if (value.Length > 1)
				{
					_nome = value;
				}
			}
		}


		public void Depositar(double deposito)
		{
			Saldo += deposito;
		}

		public void Sacar(double saque)
		{
			double TAXA_SAQUE = 5.0;
			Saldo = (Saldo - saque) - TAXA_SAQUE;
		}

		public override string ToString()
		{
			return "Conta: " + NumeroConta
					+ " Titular: " + _nome
					+ " Saldo: R$" + Saldo.ToString("F2", CultureInfo.InvariantCulture);
		}

	}
}
