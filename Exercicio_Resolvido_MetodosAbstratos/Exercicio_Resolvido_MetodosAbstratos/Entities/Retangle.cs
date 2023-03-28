using Exercicio_Resolvido_MetodosAbstratos.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Resolvido_MetodosAbstratos.Entities
{
	internal class Retangle : Shape
	{
		public double Width { get; set; }
		public double Height { get; set; }
		

		public Retangle(Color color, double width, double height) : base(color)
		{
			Width = width;
			Height = height;
		}

		public override double Area()
		{
			return Width * Height;
		}
	}
}
