using System;

namespace Hello
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("What is your name? ");
			string name = Console.ReadLine();
			Console.WriteLine("Hello, {0}!", name);
		}
	}
}
