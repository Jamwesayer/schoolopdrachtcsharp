using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
	class OpenQuestion : Question
	{
		public override string CheckAnswer(string response)
		{
			if (Antwoord.ToLower() == response.ToLower()) return "Correct";
			return string.Format("Incorrect, the answer was: {0}", Antwoord);
		}

		public override void Display()
		{
			Console.WriteLine(Vraag);
		}
	}
}
