using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lacos_ForEach
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string[] vect = new string[] { "Manoel", "Caio", "Camila", "Bruno", "Carol" };

			int n = 1;
			foreach (string objeto in  vect)
			{ 
                Console.WriteLine($"Numero {n} " + objeto);
				n++;				
            }
		}
	}
}
