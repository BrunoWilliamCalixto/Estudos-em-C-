using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobreposicao_Virtual_Override_Base.Entities
{
	internal class Account
	{
		public const double TAXA = 5.0;
		public int Number { get; protected set; }
		public string Holder { get; protected set; }
		public double Balance { get; protected set; }

		public Account()
		{
		}

		public Account(int number, string holder, double balance)
		{
			Number = number;
			Holder = holder;
			Balance = balance;
		}

		public virtual void Withdraw(double amount)
		{
			Balance -= amount + TAXA;
		}

		public void Deposit(double amount)
		{
			Balance += amount;
		}
	}
}
