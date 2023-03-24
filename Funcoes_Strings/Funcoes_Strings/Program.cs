using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcoes_Strings
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string original = "abcde FGHIJ ABC abc DEFG    ";

            string s1 = original.ToUpper();
			string s2 = original.ToLower();
			string s3 = original.Trim();

			int n1 = original.IndexOf("bc");
			int n2 = original.LastIndexOf("bc");

			string s4 = original.Substring(3);
			string s5 = original.Substring(3, 5);
			string s6 = original.Replace('a', 'x');
			string s7 = original.Replace("abc", "xxx");

			bool b1 = String.IsNullOrEmpty(original);
			bool b2 = String.IsNullOrWhiteSpace(original);
			


            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("ToUpper: -" + s1 + "-"); // Converte string em letra maiuscula
            Console.WriteLine("ToLower: -" + s2 + "-"); // Converte string em letra minuscula
            Console.WriteLine("ToLower: -" + s3 + "-"); // Elimina os espaços antes e depois de uma String
            Console.WriteLine("IndexOf ('bc'): " + n1); // Pega a posicição verdadeira do primeiro index da string
            Console.WriteLine("IndexOf ('bc'): " + n2); // Pega a posicição verdadeira do ultimo index da string
            Console.WriteLine("Substring(3): " + s4); // Recorta uma string de acordo com a posição declarada
            Console.WriteLine("Substring(3): " + s5); // Recorta uma string de acordo com a posição declarada, e a quantidade de caraceteres declarados
			Console.WriteLine("Replace: (a - x) -" + s6 + "-"); // Modifica um caractere ou string para outra denominação
			Console.WriteLine("Replace: (abc - xxx) -" + s7 + "-");
            Console.WriteLine("IsNullOrEmpty: " + b1); // Denomina se a string é vazia ou não
            Console.WriteLine("IsNullOrWhiteSpace: " + b2); // Testa a string para ver se ela contém espaço em branco ou se for vazia
        }
	}
}
