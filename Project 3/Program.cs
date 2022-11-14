using System;

namespace Project_3
{
	class Program
	{
		static void Main(string[] args)
		{
			string playAgain = "";
			RPSGame rpsGame = new RPSGame();
			while (playAgain != "N")
			{
				Console.WriteLine("Would you like to play Rock Paper Scissors? (Y/N): ");
				playAgain = Console.ReadLine();
				while (playAgain != "Y" && playAgain != "N")
				{
					Console.WriteLine("Invalid Input, please try again.");
					Console.WriteLine("Would you like to play Rock Paper Scissors? (Y/N): ");
					playAgain = Console.ReadLine().ToUpper();
				}
				if (playAgain == "Y")
				{
					Console.WriteLine("Please choose Rock (R), Paper (P), or Scissors (S): ");
					rpsGame.PlayerMove = Console.ReadLine();
					rpsGame.GetComputerMove();
					Console.WriteLine(rpsGame.DisplayMoves());
					Console.WriteLine(rpsGame.DetermineWinner());
				}
			}
			Console.WriteLine(rpsGame.ShowStats());
		}
	}
}
