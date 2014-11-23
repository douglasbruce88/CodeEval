using System;
using System.IO;

namespace GuessTheNumber
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var games = File.ReadAllLines (args [0]);

			//string[] games = { "100 Lower Lower Higher Lower Lower Lower Yay!", "948 Higher Lower Yay!" };

			foreach (var game in games)
			{
				var entries = game.Split (' ');

				int minNumber = 0;
				int maxNumber;

				Int32.TryParse(entries [0], out maxNumber);

				var guess = Math.Ceiling ((double)maxNumber / 2);

				var incorrectGuess = true;

				var i = 1;
				while (incorrectGuess)
				{
					switch (entries [i]) {

					case "Lower":
						{
							maxNumber = Convert.ToInt16(guess) - 1;
							guess = Math.Ceiling ((double)(guess-1+minNumber) / 2);
							break;
						}
					case "Higher":
						{
							minNumber = Convert.ToInt16(guess) + 1;
							guess = Math.Ceiling ((double)(maxNumber+guess+1) / 2);
							break;
						}
					case "Yay!":
						{
							Console.WriteLine (guess);
							incorrectGuess = false;
							break;
						}
					}

					i++;
				}
			}
		}
	}
}
