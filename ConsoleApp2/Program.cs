using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Question> questions = new List<Question>()
			{
				new OpenQuestion()
				{
					Vraag = "Wat is de hoofdstad van Belgie?",
					Antwoord = "Brussel",
					Moeilijkheidsgraad = 1,
					Category = "Landen"
				},
				new OpenQuestion()
				{
					Vraag = "Welke taal wordt gesproken in Brazilie?",
					Antwoord = "Spaans",
					Moeilijkheidsgraad = 1,
					Category = "Talen"
				},
			};
		}
	}
}
