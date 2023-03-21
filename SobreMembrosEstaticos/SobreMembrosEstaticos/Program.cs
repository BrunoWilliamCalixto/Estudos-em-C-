using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreMembrosEstaticos
{
	internal class Program
	{

		
		static void Main(string[] args)
		{
			

			Console.Write("Entre com o valor do raio: ");
			double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			double circ = Calculadora.Circunferencia(raio); //Armazena o resultado da variável
			double volume = Calculadora.Volume(raio);

            Console.WriteLine("Resultado da variável: " + circ.ToString("F2",  CultureInfo.InvariantCulture));

			Console.WriteLine("Resultado do volume em variável: " + volume.ToString("F2", CultureInfo.InvariantCulture));

        }

		
	}
}
