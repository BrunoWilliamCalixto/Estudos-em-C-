using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobreposicao_Virtual_Override_Base.Entities
{
	internal sealed class SavingsAccount : Account
	{
		public double InterestRate { get; set; }
		public SavingsAccount()
		{

		}
		public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
		{
			InterestRate = interestRate;
		}
		public void UpdateBalance()
		{
			Balance *= Balance * InterestRate;
		}
		public sealed override void Withdraw(double amount) //Aqui estamos falando que esse método não pode ser sobrescrito novamente de uma outra subclasse
		{
			base.Withdraw(amount); //Retorna a operação realizada apartir da instância
			Balance -= 2.0;
		}
	}
}
