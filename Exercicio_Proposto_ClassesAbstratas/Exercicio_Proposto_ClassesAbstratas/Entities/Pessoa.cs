using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Proposto_ClassesAbstratas.Entities
{
	abstract class Pessoa
	{
		public string Nome { get; protected set; }
		public double RendaAnual { get; protected set; }

		

		public Pessoa(string nome, double rendaAnual)
		{
			Nome = nome;
			RendaAnual = rendaAnual;
		}

		public abstract double CalculaImposto();

		public override string ToString()
		{
			return base.ToString();
		}
	}
}
