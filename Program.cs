using System;

namespace Hello
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, world!");
			Console.WriteLine();
			Console.Write("What is your name? ");
			string name = Console.ReadLine();
			Console.WriteLine("Hello, {0}!", name);
		}
	}
}
