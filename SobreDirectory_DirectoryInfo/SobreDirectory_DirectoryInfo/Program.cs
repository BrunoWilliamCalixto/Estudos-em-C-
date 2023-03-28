using System;
using System.Collections.Generic;
using System.Linq;

using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SobreDirectory_DirectoryInfo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string path = @"C:\Users\nobru\Pictures\temp\file1.txt";

			try
			{
				var folder = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS:");
				foreach (string s in folder)
				{
                    Console.WriteLine(s);
                }

				var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
				Console.WriteLine("FILES:");
				foreach (string s in files)
				{
					Console.WriteLine(s);
				}

				Directory.CreateDirectory(path + @"\newfolder");

			}
			catch(IOException e)
			{
                Console.WriteLine("Error: " + e.Message);
            }
		}
	}
	public class Console
	{
		public static void Write(string fmt, params object[] args) { }
		public static void WriteLine(string fmt, params object[] args) { }
		// ...
	}
}
