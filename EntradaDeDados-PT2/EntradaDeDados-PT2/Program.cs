using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntradaDeDados_PT2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            //Exercicio Proposto

            Console.WriteLine("Entre com seu nome completo: ");
            string nome = Console.ReadLine();
            string[] vetor = nome.Split(' ');
            
            string nome1 = vetor[0];
            string sobrenome = vetor[vetor.Length - 1];

            Console.WriteLine("Quantos quartos tem na sua casa?");
            int qtdQuartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço do produto: ");
            double precoQuarto = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com sua idade e altura: ");
            string[] vetor2 = Console.ReadLine().Split(' ');
            int idade = int.Parse(vetor2[0]);
            double altura = double.Parse(vetor2[1], CultureInfo.InvariantCulture);


            Console.WriteLine($"Nome: {nome}\n" +
                $"Quantidade de quartos: {qtdQuartos}\n" +
                $"Valor por Quartos: R${precoQuarto.ToString("F2")}\n" +
                $"Ultimo nome: {sobrenome}\n" +
                $"Idade: {idade}\n" +
                $"Altura: {altura.ToString("F2", CultureInfo.InvariantCulture)}");


        }
    }
}
