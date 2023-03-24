using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Program
{
	static void Main(string[] args)
	{
		// Cria um TimeSpan de 2 dias, 3 horas, 5 minutos, 7 segundos e 11 milissegundos
		TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);
		Console.WriteLine(t);

		// Exibe as propriedades do TimeSpan
		Console.WriteLine("Days: " + t.Days);
		Console.WriteLine("Hours: " + t.Hours);
		Console.WriteLine("Minutes: " + t.Minutes);
		Console.WriteLine("Seconds: " + t.Seconds);
		Console.WriteLine("Miliseconds: " + t.Milliseconds);
		Console.WriteLine("Ticks: " + t.Ticks);

		Console.WriteLine("------------------------------------");

		// Exibe as propriedades do TimeSpan em formato total
		Console.WriteLine("TotalDays: " + t.TotalDays);
		Console.WriteLine("TotalHours: " + t.TotalHours);
		Console.WriteLine("TotalMinutes: " + t.TotalMinutes);
		Console.WriteLine("TotalSeconds: " + t.TotalSeconds);
		Console.WriteLine("TotalMiliSeconds: " + t.TotalMilliseconds);

		// Cria dois TimeSpans e faz operações com eles
		TimeSpan t1 = new TimeSpan(1, 30, 10);
		TimeSpan t2 = new TimeSpan(0, 10, 5);
		TimeSpan sum = t1.Add(t2); // Soma os TimeSpans
		TimeSpan dif = t1.Subtract(t2); // Subtrai os TimeSpans

		// Cria um TimeSpan de 30 minutos e multiplica por 2.5
		TimeSpan intervaloDeTempo = TimeSpan.FromMinutes(30);
		double multiplicador = 2.5;
		TimeSpan intervaloMultiplicado = TimeSpan.FromTicks((long)(intervaloDeTempo.Duration().Ticks * multiplicador));

		// Cria um TimeSpan de 30 minutos e divide por 2.5
		TimeSpan intervaloDeTempo2 = TimeSpan.FromMinutes(30);
		double divisor = 2.5;
		TimeSpan intervaloDividido = TimeSpan.FromTicks((long)(intervaloDeTempo.Duration().Ticks / divisor));

		// Exibe os resultados das operações com TimeSpans
		Console.WriteLine(t1);
		Console.WriteLine(t2);
		Console.WriteLine(sum);
		Console.WriteLine(dif);
		Console.WriteLine(intervaloMultiplicado);
		Console.WriteLine(intervaloDividido);

		// Cria dois objetos DateTime a partir de strings e exibe as propriedades
		DateTime d1 = DateTime.Parse("2000-08-15 13:05:58");
		DateTime d2 = DateTime.Parse("2000-08-15T13:05:58Z");
		Console.WriteLine("d1: " + d1);
		Console.WriteLine("d1 Kind: " + d1.Kind);
		Console.WriteLine("d1 to Local: " + d1.ToLocalTime());
		Console.WriteLine("d1 to Utc: " + d1.ToUniversalTime());
		Console.WriteLine();
		Console.WriteLine("d2: " + d2);
		Console.WriteLine("d2 Kind: " + d2.Kind);
		Console.WriteLine("d2 to Local: " + d2.ToLocalTime());
		Console.WriteLine("d2 to Utc: " + d2.ToUniversalTime());
		Console.WriteLine();
		Console.WriteLine(d2.ToString("yyyy-MM-ddTHH:mm:ssZ"));
	}
}

