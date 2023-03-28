using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Proposto_ClassesAbstratas.Entities
{
	internal class PessoaFisica : Pessoa
	{
		const double IMPOSTO_MIN = 0.15;
		const double IMPOSTO_MAX = 0.25;

		public double GastoSaude { get; private set; }

		public PessoaFisica(string nome, double rendaAnual, double gastoSaude) : base(nome, rendaAnual)
		{
			GastoSaude = gastoSaude;
		}

		public sealed override double CalculaImposto()
		{
			double imposto;

			if (RendaAnual <= 20000.00)
			{
				imposto = RendaAnual * IMPOSTO_MIN - GastoSaude * 0.5;
				return imposto;
			}
			imposto = RendaAnual * IMPOSTO_MAX - GastoSaude * 0.5;
			return imposto;
		}
	}		
}
