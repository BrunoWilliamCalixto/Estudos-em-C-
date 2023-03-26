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
			Account acc = new Account(1001, "Bruno William", 500.00);
			BusinessAccount bAcc = new BusinessAccount(8002, "Eagle MS", 0.0, 500.0);

			//UPCASTING
			Account acc1 = bAcc;
			Account acc2 = new BusinessAccount(1003, "Bob Marley", 0.0, 1000.0); // Podemos dar um new na subclasse e atribuir novos valores a ela
			Account acc3 = new SavingsAccount(1004, "Ana", 0.0, 100.00);

			// DOWNCASTING
			 BusinessAccount acc4 = (BusinessAccount) acc2;
			acc4.Loan(100.0);

			//BusinessAccount acc5 = (BusinessAccount) acc3; -> Uma variável que dá erro por pertencer a duas classe distintas

			if(acc3 is BusinessAccount) //is é um tipo que diz: "Se acc3 for uma instancia de BussnessAccount", realizamos o downcasting, senão ele nega a condição
			{
				//BusinessAccount acc5 = (BusinessAccount) acc3;
				BusinessAccount acc5 = acc3 as BusinessAccount; //as [e tratatado tipo "como", ou seja, a sua instancia está se referindo acc3 como BusinessAccount (sintaxe alternativa)
				acc5.Loan(200.00);
                Console.WriteLine("Loan!");
            }
			if(acc3 is SavingsAccount)
			{
				SavingsAccount acc5 = (SavingsAccount) acc3;
				acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }
		}
	}
}
