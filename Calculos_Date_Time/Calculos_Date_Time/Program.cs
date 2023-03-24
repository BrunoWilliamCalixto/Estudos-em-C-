using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;



namespace Calculos_Date_Time
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Obtém a data e hora atual
			DateTime dT1 = DateTime.Now;

			// Converte a data e hora para string usando diferentes formatos
			string s1 = dT1.ToLongDateString();
			string s2 = dT1.ToLongTimeString();
			string s3 = dT1.ToShortDateString();
			string s4 = dT1.ToShortTimeString();
			string s5 = dT1.ToString();
			string s6 = dT1.ToString("yyyy*MM*dd HH:mm:ss");
			string s7 = dT1.ToString("yyyy*MM*dd HH:mm:ss.fff");

			// Imprime as propriedades da data e hora atual
			Console.WriteLine("1) Date: " + dT1.Date);
			Console.WriteLine("2) Day: " + dT1.Day);
			Console.WriteLine("3) DayOfWeek: " + dT1.DayOfWeek);
			Console.WriteLine("4) DayOfYear: " + dT1.DayOfYear);
			Console.WriteLine("5) Hour: " + dT1.Hour);
			Console.WriteLine("6) Kind: " + dT1.Kind);
			Console.WriteLine("7) Milisecond: " + dT1.Millisecond);
			Console.WriteLine("8) Minute: " + dT1.Minute);
			Console.WriteLine("9) Month: " + dT1.Month);
			Console.WriteLine("10) Seconds: " + dT1.Second);
			Console.WriteLine("11) Ticks: " + dT1.Ticks);
			Console.WriteLine("12) TimeOfDay: " + dT1.TimeOfDay);
			Console.WriteLine("13) Year: " + dT1.Year);

			// Imprime as strings formatadas da data e hora atual
			Console.WriteLine("--------------------------------------------");
			Console.WriteLine(s1);
			Console.WriteLine(s2);
			Console.WriteLine(s3);
			Console.WriteLine(s4);
			Console.WriteLine(s5);
			Console.WriteLine(s6);
			Console.WriteLine(s7);

			// Cria duas novas instâncias de DateTime
			DateTime d1 = new DateTime(2001, 8, 15, 13, 45, 58);
			DateTime d2 = dT1.AddHours(2);

			// Imprime as duas datas criadas
			Console.WriteLine(d1);
			Console.WriteLine(d2);

			// Cria uma nova instância de DateTime com a data e hora atual
			DateTime d3 = DateTime.Now;

			// Adiciona 7 dias à data e hora atual
			DateTime d4 = d3.AddDays(7);

			// Calcula a diferença de tempo entre as duas datas
			TimeSpan t1 = d4.Subtract(d3);

			// Imprime o número de dias entre as datas e a data de vencimento
			Console.WriteLine($"Vencimento: " + t1.Days + "\nData de vencimento: " + d4.Date.ToString("dd/MM/yyyy"));

			Console.WriteLine("Digite uma data no formato dd/MM/yyyy: ");
			string inputData = Console.ReadLine();

			DateTime data;
			if (DateTime.TryParse(inputData, out data))
			{
				Console.WriteLine("Data digitada: " + data.ToString());
			}
			else
			{
				Console.WriteLine("Data inválida!");
			}
		}
	}
}
