using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacao_MembrosEstaticos
{
	internal class ConversorDeMoeda
	{
		public static double IOF = 0.06;
		

		public static double ConversaoDolarParaReal(double cotacaoDolar, double dolaresAComprar)
		{
			double conversao = dolaresAComprar * cotacaoDolar;
			return conversao +=  (conversao * IOF);

		}
	}
}
