using System;

namespace Project1
{
	class Program
	{
		static void Main(string[] args)
		{
			MysteryNumber mysteryNumber = new MysteryNumber();
			int userGuesses = 5;
			bool gameOverFlag = false;
			while (userGuesses > 0 && !gameOverFlag)
			{
				userGuesses--;
				Console.Write("Please enter a number: ");
				int userGuess = int.Parse(Console.ReadLine());
				if (mysteryNumber.RandomNumber == userGuess)
				{
					gameOverFlag = true;
					Console.WriteLine("You have guessed correctly.");
					Console.WriteLine($"It took you {5 - userGuesses} tries.");
				}
				else
				{
					Console.WriteLine("You have guessed incorrectly.");
					Console.WriteLine($"You have made {5 - userGuesses} guesses.");
					Console.WriteLine($"You have {userGuesses} tries left.");
				}
			}
		}
	}
}
