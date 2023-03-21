using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3_Sobre_ClasseEMetodos
{
	internal class Aluno
	{
		public string Nome;
		public double Nota1;
		public double Nota2;
		public double Nota3;
		public double NotaFinal;
		public double PONTUACAO_FINAL = 60;

		public double CalcularNota()
		{
			return NotaFinal = Nota1 + Nota2 + Nota3;
		}

		public double SubtrairNota()
		{
			return PONTUACAO_FINAL - NotaFinal;
		}

		public bool Aprovado()
		{
			if(CalcularNota() >= PONTUACAO_FINAL)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		public override string ToString()
		{
			if(Aprovado())
			{
				return "NOME DO ALUNO: "
						+ Nome
						+ "\nNOTA FINAL = "
						+ CalcularNota().ToString("F2", CultureInfo.InvariantCulture)
						+ "\nAPROVADO";
			}
			
			
		return "NOME DO ALUNO: "
				+ Nome
				+ "\nNOTA FINAL = "
				+ CalcularNota().ToString("F2", CultureInfo.InvariantCulture)
				+ "\nREPROVADO"
				+ "\nFALTARAM " + SubtrairNota().ToString("F2", CultureInfo.InvariantCulture) + " PONTOS";
			
		}
	}
}
