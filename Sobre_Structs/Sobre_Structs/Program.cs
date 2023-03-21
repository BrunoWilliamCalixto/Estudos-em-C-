using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobre_Structs
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Point p;

			p.x = 10;
			p.y = 20;

            Console.WriteLine(p);

            Point p1 = new Point();
			p1.x = 10;
			p1.y = 35;

			Console.WriteLine(p1);

			Nullable<double> AdressNumber = null; //Declaramos que a variável do tipo double AdressNumber, se inicie com valor nulo
			double? x1 = null;
			double? y1 = 10.0;

            Console.WriteLine(x1.GetValueOrDefault()); //pega o valor de x e retorna o valor padrão
            Console.WriteLine(y1.GetValueOrDefault()); // pega o valor de y e retorna o valor atribuido

            Console.WriteLine(x1.HasValue);
            Console.WriteLine(y1.HasValue);

			if (x1.HasValue) // Se o x1 tiver um valor
			{
                Console.WriteLine(x1.Value); // imprima o valor
            }
			else
			{
                Console.WriteLine("Valor de X é nulo"); // Lancou uma exceção genérica caso o x seja um valor nulo
            }

			if (y1.HasValue)
			{
				Console.WriteLine(y1.Value);
			}
			else
			{
				Console.WriteLine("Valor de Y é nulo");
			}

			double? x = 100;
			double? y = x ?? 10.0; // caso x tenha valor, recebe x, caso seja nula, recebe 10

            Console.WriteLine(y);


        }
	}
}
