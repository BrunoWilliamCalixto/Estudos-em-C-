using SobreHeranca.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreHeranca
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<Account> list = new List<Account>();

			list.Add(new SavingsAccount(1001, "Alex", 500.00, 0.01));
			list.Add(new BusinessAccount(1002, "Maria", 500.00, 400.00));
			list.Add(new SavingsAccount(1003, "Bob", 500.00, 0.01));
			list.Add(new BusinessAccount(1004, "Anna", 500.00, 500.00));

			double sum = 0.0;

			foreach (Account account in list)
			{
				sum += account.Balance;
			}
			
			Console.WriteLine(sum);


			foreach(Account account in list)
			{
				account.Withdraw(10.0);
			}

			foreach (Account account in list)
			{
                Console.WriteLine(account.Balance);
            }

			SavingsAccount sA = new SavingsAccount(1005, "Bruno", 1000, 0.10);
			sA.UpdateBalance();

			Console.WriteLine(sA.Balance); ;

        }
	}
}
