using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Fixacao_Listas
{
	internal class Funcionario
	{
		public int Id { get; set; }
		public string Nome { get; set; }

        public double Salario { get; private set; }

		public Funcionario() { }

		public Funcionario(int id, string nome, double salario)
		{
			Id = id;
			Nome = nome;
			Salario = salario;
		}

		public void AumentarSalario(double porcentagem)
		{
			double acrescimoPorcentagem = (Salario * porcentagem / 100);
			Salario += acrescimoPorcentagem;
		}

		public override string ToString()
		{
			return Id + ", " + Nome + ", " + "R$" + Salario;
		}
	}
}
