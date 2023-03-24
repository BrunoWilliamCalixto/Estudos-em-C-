using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modicador_Parametro_Params
{
	internal class Calculadora
	{
		public static int Sum(params int[] numbers)
		{
			int sum = 0;
			for(int i = 0; i < numbers.Length; i++)
			{
				sum += numbers[i];
			}

			return sum;
		}
		
		public static void Triplicar(ref int x) // Com o ref em um escopo do tipo void,
												// atribuimos que em vez do int ser um tipo struct, ele será um tipo referencia, então irá armazenar e calcular o valor de volta
		{
			x = x * 3;
		}

		public static void Triplicar1(int origem, out int resultado)
		{
			resultado = origem * 3;
		}
	}
}
