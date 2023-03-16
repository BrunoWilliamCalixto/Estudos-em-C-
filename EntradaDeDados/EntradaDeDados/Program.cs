using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EntradaDeDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();
            string a = Console.ReadLine();
           

            Console.WriteLine($"Você digitou {frase}");
            Console.WriteLine($"Você digitou {x}");
            Console.WriteLine($"Você digitou {y}");
            Console.WriteLine($"Você digitou {z}");
            Console.WriteLine($"Você digitou {a}");

            String s = Console.ReadLine();
            string[] vet = s.Split(' ');

            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];

            Console.WriteLine("Digitado {0} {1} {2}", p1 , p2 , p3);
            

        }
    }
}
