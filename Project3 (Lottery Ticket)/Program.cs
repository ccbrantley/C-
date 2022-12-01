using System;

namespace Project3__Lottery_Ticket_
{
	class Program
	{
		void CheckInput()
		{
			
		}
		static void Main(string[] args)
		{
			LottoGame lottoGame = new LottoGame();
			string response = "Y";
			while (response == "Y" || response == "y")
			{
				Console.Write($"Would you like to purchase and scratch off a lottery ticket for {lottoGame.Price:C}? (Y/N) ");
				response = Console.ReadLine();
				while (response != "Y" && response != "y" && response != "N" && response != "n")
				{
					Console.WriteLine("You're input is invalid. Please try again.");
					Console.Write($"Would you like to purchase and scratch off a lottery ticket for {lottoGame.Price:C}? (Y/N) ");
					response = Console.ReadLine();
				}
				Console.Clear();
				if (response == "Y" || response == "y")
				{
					lottoGame.Loop();
				}
			}
			Console.Clear();
			lottoGame.DisplayTotalWinnings();
		}
	}
}
