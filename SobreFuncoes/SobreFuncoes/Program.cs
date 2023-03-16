using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreFuncoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 3 números em sequencia: ");

            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            int resultado = Maior(n1, n2, n3);

            

            Console.WriteLine($"{resultado} é maior");



        }

        private static int Maior(int n1, int n2, int n3)
        {
            int resultado = 0;

            if (n1 > n2 && n1 > n3)
            {
                resultado = n1;
            }
            else if (n2 > n3)
            {
                resultado = n2;
            }
            else
            {
                resultado = n3;
            }

            return resultado;
        }
    }
}
