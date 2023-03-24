using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modicador_Parametro_Params
{
	internal class Program
	{
		static void Main(string[] args)
		{

			int s1 = Calculadora.Sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11);

            Console.WriteLine(s1);

			int a = 10;
			Calculadora.Triplicar(ref a); // referencia que armazena o valor no int x de triplicar
            Console.WriteLine(a);

			int triple;
			Calculadora.Triplicar1(a, out triple);

            Console.WriteLine(triple);
        }
	}
}
