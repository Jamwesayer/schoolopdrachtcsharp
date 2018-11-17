using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
	abstract class Question
	{
		public string Vraag { get; set; }
		public string Antwoord { get; set; }
		public int Moeilijkheidsgraad { get; set; }
		public string Category { get; set; }

		public void PresentQuestion()
		{
			Display();
			Console.WriteLine("Your answer: ");
			string response = Console.ReadLine();
			Console.WriteLine(CheckAnswer(response));
		}

		public abstract void Display();
		public abstract string CheckAnswer(string response);
	}

}
