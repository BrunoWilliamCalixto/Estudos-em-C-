using Exercicio_Resolvido_MetodosAbstratos.Entities;
using Exercicio_Resolvido_MetodosAbstratos.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Resolvido_MetodosAbstratos
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<Shape> list = new List<Shape>();	

			Console.Write("Enter the number of shapes: ");
			int n = int.Parse(Console.ReadLine());

			for(int i = 1; i <= n; i++)
			{
                Console.WriteLine($"Shape #{i} data:");
				Console.Write("Retangle or Circle (r/c): ");
				string option = Console.ReadLine().ToLower().Substring(0,1);
                Console.Write("Color (Black/Blue/Red): ");
				Color color = (Color)Enum.Parse(typeof(Color), Console.ReadLine()); 

				if( option == "r")
				{
                    Console.Write("Width: ");
					double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
					Console.Write("Height: ");
					double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
					Shape retangle = new Retangle(color, width, height);
					list.Add(retangle);
				}

				if( option == "c")
				{
					Console.Write("Radius: ");
					double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
					Shape circle = new Circle(color, radius);
					list.Add(circle);
				} 
            }

			Console.WriteLine("SHAPE AREAS: ");
			foreach (Shape shape in list)
			{
				Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
			}
		}
	}
}
