
using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
	class ChoiceQuestion : Question
	{
		public List<string> Opties { get; set; }

		public override string CheckAnswer(string response)
		{
			int I = 0;
			Int32.TryParse(response, out I);
			return (Antwoord == Opties[I - 1]) ? "Correct" : string.Format("Incorrect, the answer was {0}", response + 1);
		}

		public override void Display()
		{
			Console.WriteLine(Vraag);
			for(int i = 0; i < Opties.Count; i++)
			{
				Console.WriteLine(string.Format("{0}: {1}", i + 1, Opties[i]));
			}
		}
	}
}
