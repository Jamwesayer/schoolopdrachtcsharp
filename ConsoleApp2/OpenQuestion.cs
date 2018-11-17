using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
	class OpenQuestion : Question
	{
		public string Antwoord { get; set; }
		public override string CheckAnswer(string response)
		{
			if (Antwoord == response) return "Correct";
			return string.Format("Incorrect, the answer was: {0}", Antwoord);
		}
	}
}
