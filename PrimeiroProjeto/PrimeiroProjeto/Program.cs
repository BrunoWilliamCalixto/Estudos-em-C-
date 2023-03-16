
using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = "Bruno William";
            Console.WriteLine(nome);
            double saldo = 10.45432;
            Console.WriteLine(saldo.ToString("F2")); // To String que realiza a formatação do contèúdo saldo, F2 é o número de casas decimais
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture)); //Independente da Linguagem, é formatado com .

            // Métodos para formatar, concatenar e interpolar os objetos
            string nome1 = "Maria";
            double saldo1 = 10.586964;
            int idade = 32;

            Console.WriteLine("{0} tem {1} anos e tem saldo igual a R${2} e reais", nome1, idade, saldo1.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a R${saldo1.ToString("F2", CultureInfo.InvariantCulture)} e reais");

            //Exercicios Propostos
            Console.WriteLine("-------------------------------------------------------------------------");
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade1 = 30;
            int codigo = 6290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.20;
            double medida = 53.45323;
            
            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo preço é ${preco1:F2}\n" +
                $"{produto2}, cujo preço é ${preco2:F2}\n");

            Console.WriteLine($"Registro: {idade1} anos de idade, cógigo {codigo} e gênero: {genero}\n");
            Console.WriteLine("Medida com oito casa decimais: " + medida);
            Console.WriteLine($"Arredondado (três casas decimais): {medida:F3}");
            Console.WriteLine("Separador decimal invariant culture: {0}", medida.ToString("F3", CultureInfo.InvariantCulture));




        }
    }
}
