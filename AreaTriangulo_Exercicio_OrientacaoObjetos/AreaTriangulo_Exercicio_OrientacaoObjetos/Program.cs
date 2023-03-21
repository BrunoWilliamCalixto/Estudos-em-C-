using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaTriangulo_Exercicio_OrientacaoObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            

            Console.WriteLine("Digite um numero: ");
            numero = int.Parse(Console.ReadLine());
            

            Console.WriteLine();
            for (int i = numero; i > 0; i--)
            {
                Console.WriteLine($"{i}° Resultado: {numero} * {i}");
                numero = numero * i;
            }
            Console.WriteLine($"Resultado fatorial do quadrante é :{numero}");

        }   


    }
}
