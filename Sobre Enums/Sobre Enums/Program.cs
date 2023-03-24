using Sobre_Enums.Entities;
using Sobre_Enums.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobre_Enums
{
	class Program
	{
		static void Main(string[] args)
		{
			Order order = new Order
			{
				Id = 1,
				Moment = DateTime.Now,
				Status = OrderStatus.PendingPayment
			};

			Console.WriteLine(order);

			string txt = OrderStatus.PendingPayment.ToString();

            Console.WriteLine(txt);

			

				

			}

	}
}

//OrderStatus: É o tipo do enum que estamos analisando.
//os: É a variável que está recebendo o valor analisado.
//Enum.Parse: É o método que estamos usando para analisar a string "Delivered" e convertê-la para o tipo de enumeração.
//typeof(OrderStatus): É o tipo de enumeração que queremos analisar. Este valor é passado como um objeto do tipo System.Type.
//"Delivered": É a string que estamos analisando e que representa o membro do enum OrderStatus com um valor de 3.
//(OrderStatus): É uma conversão explícita para o tipo de enumeração OrderStatus, para que a variável "os" receba o valor correto após a análise da string.


