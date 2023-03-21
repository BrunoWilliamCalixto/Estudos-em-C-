using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaRepetitiva_Enquanto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                Console.WriteLine("Digite um numero: ");
                double numero = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));

                if(numero > 0)
                {
                    double raiz = Math.Sqrt(numero);
                    Console.WriteLine($"Raiz quadrada de {numero} é {raiz.ToString("F5", CultureInfo.InvariantCulture)}");
                }
                else
                {
                    Console.WriteLine("Número negativo!");
                    break;
                }
            }

            Console.WriteLine("Fim do While");
        }
    }
}
