using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Tutorial
{
	class Program
	{
		static void Main(string[] args)
		{
			// plaintext
			string characterName = "Ryan";
			char grade = 'A';

			// number (decimal is used for extreme accuracy)
			int characterAge = 22;
			double gpa = 3.45;

			// boolean
			bool isMale = true;

			// getting user input
			Console.WriteLine("Enter your name: ");
			string name = Console.ReadLine();
			Console.WriteLine("Hello, " + name);

			Console.ReadLine();

			//Console.WriteLine( characterName.Length);
			//Console.WriteLine( characterName.ToUpper());
			//Console.WriteLine( characterName.ToLower());
			//Console.WriteLine( characterName[0]);
			//Console.WriteLine( characterName.Contains("an"));

			//Console.WriteLine("Hello World!" );
			//Console.WriteLine("This is " + characterName + "!");
			//Console.WriteLine("I am " + characterAge + " years old!");
			//Console.ReadLine();
		}
	}
}
