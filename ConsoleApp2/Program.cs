using System;

namespace ConsoleApp2
{
	class Program
	{
		static void Main(string[] args)
		{
			ChoiceQuestion test = new ChoiceQuestion()
			{
				Vraag = "Test",
				Moeilijkheidsgraad = 1,
				Category = "Landen"
			};
			test.PresentQuestion();
		}
	}
}
