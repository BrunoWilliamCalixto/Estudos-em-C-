using Exercicio_Resolvido_MetodosAbstratos.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Resolvido_MetodosAbstratos.Entities
{
	abstract class Shape
	{
        public Color Color { get; set; }

	
		public Shape(Color color)
		{
			Color = color;
		}

		public abstract double Area();
		

	}
}
