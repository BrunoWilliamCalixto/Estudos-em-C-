using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Proposto_ClassesAbstratas.Entities
{
	internal class PessoaJuridica : Pessoa
	{
		public int NumeroFuncionarios { get; set; }

		public PessoaJuridica(string nome, double rendaAnual, int numeroFuncionarios) : base(nome, rendaAnual)
		{
			NumeroFuncionarios = numeroFuncionarios;
		}


		public override double CalculaImposto()
		{
			double imposto;
			if(NumeroFuncionarios > 10)
			{
				imposto = RendaAnual * 0.14;
				return imposto;
			}
			imposto = RendaAnual * 0.16;
			return imposto;
		}

	}
}
