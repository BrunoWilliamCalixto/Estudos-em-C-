using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreListas_ArrayList
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<string> list = new List<string>();

			list.Add("Bruno");
			list.Add("Carlos");
			list.Insert(2, "Neymar");
			list.Add("Carolina");
			list.Add("Alex");
			list.Add("Ana");

			foreach (string item in list) {
				Console.WriteLine(item);
			}

            Console.WriteLine("Contagem da lista " + list.Count); //Contador de elementos da lista

			string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("Primero nome encontrado com A no começo: " + s1);

			string s2 = list.FindLast(x => x[0] == 'A'); // Ultima ocorrencia de quem começa com A
            Console.WriteLine("Nome da ultima ocorrencia que começa com A: " + s2);

			int pos1 = list.FindIndex(x => x[0] == 'A');// Pega o index do primeiro elemento que começa com a letra A
			Console.WriteLine("Posição começando com A: " + pos1);

			int pos2 = list.FindLastIndex(x => x[0] == 'A'); // Pega o index do último elemento que começa com a letra A
			Console.WriteLine("Posição começando com A: " + pos2);

			List<string> list2 = list.FindAll(x => x.Length < 6);

			foreach(string item in list2)
			{
                Console.WriteLine("Nomes com menos de 6 caracteres " + item);
            }

			list.RemoveAll(x => x[0] == 'A');
			Console.WriteLine("-----------------------------------------");
			foreach (string item in list)
			{
                Console.WriteLine(item);
			}
		}
	}
}
