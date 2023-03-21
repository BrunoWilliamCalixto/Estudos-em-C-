using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaRepetitiva_FOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos numeros você irá digitar?: ");
            int n = int.Parse(Console.ReadLine());
            int resultado = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"{i + 1}° número: ");
                int numero = int.Parse(Console.ReadLine());

                resultado += numero;

            } // FIM DO MÉTODO FOR
            Console.WriteLine($"SOMA: {resultado}");


            Console.Write("Quantos numeros você irá digitar?: ");
            int n1 = int.Parse(Console.ReadLine());
            int impar = 0;

            Console.WriteLine("Numeros impares");
            for (int i = 0; i < n1; i++)
            {
                if (i % 2 == 1)
                {
                    impar = i;
                    Console.WriteLine(impar);
                }

            }// fim do método FOR2


            Console.Write("Quantos numeros você irá digitar?: ");
            int n2 = int.Parse(Console.ReadLine());
            double resultado1 = 0;
            int PESO_1 = 2;
            int PESO_2 = 3;
            int PESO_3 = 5;

            for (int i = 0 ; i < n2; i++) {
                
                Console.Write("Digite a quantidade de testes: ");
                double numero1 = double.Parse(Console.ReadLine());
                double numero2 = double.Parse(Console.ReadLine());
                double numero3 = double.Parse(Console.ReadLine());

                resultado1 = (numero1 * PESO_1) + (numero2 * PESO_2) + (numero3 * PESO_3);
                double mediaPonderada = resultado1 / (PESO_1 + PESO_2 + PESO_3);
                Console.WriteLine($"resultado {i + 1}° teste: {mediaPonderada.ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
