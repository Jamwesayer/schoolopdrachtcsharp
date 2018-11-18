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
					Vraag = "Welke taal wordt gesproken in Duitsland?",
					Antwoord = "Duits",
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

			// specifieke category
			IEnumerable<Question> SpecificCatQuestion =
				from question in questions
				where question.Category.Equals("Talen")
				select question;
			SpecificCatQuestion.ToList();

			// specifieke moeilijksheidgraad
			IEnumerable<Question> SpecificDifficultyQuestion =
				from question in questions
				where question.Moeilijkheidsgraad.Equals(1)
				select question;
			SpecificCatQuestion.ToList();

			// georderd van makkelijk naar moeilijk
			var SortByDifficulty = questions.OrderBy(q => q.Moeilijkheidsgraad).ToList();

			// georderd op category
			var SortByCategory = questions.OrderBy(q => q.Category).ToList();

			foreach (Question question in SortByCategory)
			{
				question.PresentQuestion();
			}
			Console.ReadLine();
		}
	}
}
