using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobre_TimeSpan
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Criando instâncias de TimeSpan com diferentes valores
			TimeSpan t1 = new TimeSpan(); // TimeSpan de 0 ticks
			TimeSpan t2 = new TimeSpan(900000000L); // TimeSpan de 900000000 ticks
			TimeSpan t3 = new TimeSpan(22, 2, 11, 21); // TimeSpan de 22 dias, 2 horas, 11 minutos e 21 segundos
			TimeSpan t4 = new TimeSpan(22, 2, 11, 21, 321); // TimeSpan de 22 dias, 2 horas, 11 minutos, 21 segundos e 321 milissegundos

			// Imprimindo os valores dos TimeSpans criados acima
			Console.WriteLine(t1);
			Console.WriteLine(t2);
			Console.WriteLine(t3);
			Console.WriteLine(t4);

			// Criando instâncias de TimeSpan a partir de diferentes unidades de medida
			TimeSpan t5 = TimeSpan.FromDays(1.5); // TimeSpan de 1 dia e meio (36 horas)
			TimeSpan t6 = TimeSpan.FromHours(1.5); // TimeSpan de 1 hora e meia (90 minutos)
			TimeSpan t7 = TimeSpan.FromMinutes(1.5); // TimeSpan de 1 minuto e meio (90 segundos)
			TimeSpan t8 = TimeSpan.FromSeconds(1.5); // TimeSpan de 1 segundo e meio (1500 milissegundos)
			TimeSpan t9 = TimeSpan.FromMilliseconds(1.5); // TimeSpan de 1.5 milissegundos

			// Imprimindo os valores dos TimeSpans criados acima
			Console.WriteLine(t5);
			Console.WriteLine(t6);
			Console.WriteLine(t7);
			Console.WriteLine(t8);
			Console.WriteLine(t9);
		}
	}
}