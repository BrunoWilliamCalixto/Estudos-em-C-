using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_EstuturaWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) // Começo do método
            {
                Console.WriteLine("Digite a coordenada X: ");
                int x = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite a coordenada Y: ");
                int y = int.Parse(Console.ReadLine());

                if (x > 0 && y > 0)
                {
                    Console.WriteLine("Primeiro");
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("Segundo");
                }
                else if (x < 0)
                {
                    Console.WriteLine("Terceiro");
                }
                else
                {
                    break;
                }
            } // fim do método While

            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;
            while (true)
            {
                Console.WriteLine("Digite a opção desejada: \n" +
                    "1 - Álcool\n" +
                    "2 - Gasolina\n" +
                    "3 - Diesel\n" +
                    "4 - Fim");
                int numero = int.Parse(Console.ReadLine());

                if(numero == 1)
                {
                    alcool++;
                }
                else if(numero == 2)
                {
                    gasolina++;
                }
                else if(numero == 3)
                {
                    diesel++;
                }
                else if(numero == 4)
                {
                    break;
                }
                else
                {
                    continue;
                }
            } // Fim do segundo método While

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine($"Álcool: {alcool}\n" +
                $"" + $"Gasolina: {gasolina}\n" +
                $"" + $"Diesel: {diesel}");
        }
    }
}
