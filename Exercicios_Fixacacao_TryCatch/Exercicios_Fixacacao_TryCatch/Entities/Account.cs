using System;
using System.Globalization;
using Exercicios_Fixacacao_TryCatch.Entities.Exceptions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Fixacacao_TryCatch.Entities
{
	internal class Account
	{
		public int Number { get; private set; }
		public string Holder { get; private set; }
		public double Balance { get; private set; }
		public double Wihtdrawlimit { get; private set; }

		public Account()
		{
		}

		public Account(int number, string holder, double balance, double wihtdrawlimit)
		{
			Number = number;
			Holder = holder;
			Balance = balance;
			Wihtdrawlimit = wihtdrawlimit;
		}

		public void Deposit(double amount)
		{
			if(amount > 1000)
			{
				throw new DomainException("Limite de depósito não permitido");
			}
			Balance += amount;
		}

		public void Withdraw(double amount)
		{
			if(Balance <= 0 || amount > Balance)
			{
				throw new DomainException("Saldo insuficiente");
			}
			if(amount > Wihtdrawlimit)
			{
				throw new DomainException("O limite é maior que o permitido");
			}
			Balance -= amount;
		}

		public override string ToString()
		{
			return base.ToString();
		}
	}
}
