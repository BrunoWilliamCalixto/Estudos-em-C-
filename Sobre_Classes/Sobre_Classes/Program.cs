using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobre_Classes
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Triangulo x, y;

			x = new Triangulo();
			y = new Triangulo();

			Console.WriteLine("Digite o valor das medidas do Triângulo X: ");
			 x.A= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			 x.B= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			 x.C= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			Console.WriteLine("Digite o valor das medidas do Triângulo Y: ");
			y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			double areaX = x.Area();
			double areaY = y.Area();

			Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
			Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

			if (areaX > areaY)
			{
				Console.WriteLine("Area X é maior");
			}
			else
			{
				Console.WriteLine("Area Y é maior");
			}
		}
	}
}
