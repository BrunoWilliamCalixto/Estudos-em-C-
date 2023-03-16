using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores_Atribuicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 5.1;
            int b = (int)a;

            int x = 5;
            int y = 2;

            double resultado = (double)x / y ;

            Console.WriteLine(b);
            Console.WriteLine(resultado);


            //Operadores Aritméticos

            // Nada em parte do que já vimos,

            /*
             Precedencia da esquerda para a direita, quando os parenteses não são acionados
            / * % São de prioridade 1, eles serão executados primeiro
            + - vem na segunda precedencia

            Math.pow = realiza a exponenciação
            Math.sqrt = realiza a raíz quadrada
             */
            
        }

    }
}
