using System;
using System.Collections.Generic;
using System.Linq;

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
				new ChoiceQuestion()
				{
					Vraag = "Welke taal wordt gesproken in Brazilie?",
					Antwoord = "Spaans",
					Opties = new List<string>(){"Italiaans", "Nederlands", "Duits", "Spaans"},
					Moeilijkheidsgraad = 3,
					Category = "Talen"
				},
				new OpenQuestion()
				{
					Vraag = "Hoeveel is 2 * 2",
					Antwoord = "4",
					Moeilijkheidsgraad = 2,
					Category = "Rekenen"
				},
			};

			IEnumerable<Question> SpecificCatQuestion =
				from question in questions
				where question.Category.Contains("Talen")
				select question;
			SpecificCatQuestion.ToList();

			var SortByDifficulty = questions.OrderBy(q => q.Moeilijkheidsgraad).ToList();

			foreach (Question question in SpecificCatQuestion)
			{
				question.PresentQuestion();
			}
			Console.ReadLine();
		}
	}
}
