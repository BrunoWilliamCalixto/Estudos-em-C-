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
		public double ValorContaBancaria { get; private set; }


		public ContaBancaria()
		{
		}

		public ContaBancaria(string nome, int numeroConta)
		{
			_nome = nome;
			NumeroConta = numeroConta;
		}

		public ContaBancaria(string nome, int numeroConta, double valorInicial) : this(nome, numeroConta)
		{
			ValorContaBancaria = valorInicial;
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


		public void Depositar(double saldo)
		{
			ValorContaBancaria += saldo;
		}

		public void Sacar(double saldo)
		{
			double TAXA_SAQUE = 5.0;
			ValorContaBancaria = (ValorContaBancaria - saldo) - TAXA_SAQUE;
		}

		public override string ToString()
		{
			return "Conta: " + NumeroConta
					+ " Titular: " + _nome
					+ " Saldo: R$" + ValorContaBancaria.ToString("F2", CultureInfo.InvariantCulture);
		}

	}
}
