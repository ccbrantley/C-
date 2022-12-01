using System;
using System.Collections.Generic;
using System.Text;

namespace Project3__Lottery_Ticket_
{
	class LottoGame
	{
		// Class Attributes.
		private int[] numbers = new int[15]; // Array to hold random integers
		private int prize;
		private int winningNumber;
		private int totalWinnings;
		private int price = 10;
		private int ticketsSold = 0;

		// Constructor to Create a New Lotto Game
		public LottoGame()
		{

		}

		public int[] Numbers
		{

			get { return numbers; }

		}

		public int Prize
		{

			get { return prize; }

		}

		public int WinningNumber
		{

			get { return winningNumber; }

		}

		public int TotalWinnings
		{

			get { return totalWinnings; }

		}

		public int Price
		{
			get { return price; }
		}

		public int TicketsSold
		{
			get { return ticketsSold; }
		}

		public void Loop ()
		{
			++ this.ticketsSold;
			this.ShowRules();
			this.DisplayWinNumAndPrize();
			this.DisplayBlankTicket();
			Console.WriteLine();
			Console.Write("\tPress \"Enter\" to scratch off your ticket...");
			Console.ReadLine();
			Console.Clear();
			this.GenerateRandomNumbers();
			this.GenerateWinningNumber();
			this.GeneratePrizeValue();
			this.ShowRules();
			this.DisplayWinNumAndPrize(this.WinningNumber.ToString(), this.Prize.ToString("C"));
			this.DisplayTicket();
			this.UpdateTotalWinnings(this.Prize * this.CheckForWinner());
			Console.WriteLine();
			Console.WriteLine($"\tYou have won {this.Prize * this.CheckForWinner():C}");
			Console.WriteLine();
		}

		public void ShowRules()
		{
			// Fill in code to display your game rules
			Console.WriteLine("*************** Lottery Scratch Off Ticket ***************");
			Console.WriteLine("Rules:");
			Console.WriteLine($"Each lottery ticket costs {10:C}.");
			Console.WriteLine("Please scratch off the lottery ticket to see if you have won a prize!");
			Console.WriteLine("There are 15 numbers to scratch off.");
			Console.WriteLine("A random number is chosen and the amount of times it appears");
			Console.WriteLine("on the card multiplied by the prize value is your prize amount!");
			Console.WriteLine();

		}

		public void GenerateWinningNumber()
		{
			Random rand = new Random();
			winningNumber = rand.Next(40) + 10; // Modify for desired range of numbers

		}

		public void GenerateRandomNumbers()
		{
			Random rand = new Random();
			for (int x = 0; x < 15; x++)
			{
				numbers[x] = rand.Next(40) + 10; // Modify for desired range of numbers

			}
		}

		public void GeneratePrizeValue()
		{
			Random rand = new Random();
			int num = rand.Next(3) + 1; // 3 random prizes generated.
			// Change these prize amounts as desired.
			if (num == 1)
				prize = 5;
			else if (num == 2)
				prize = 20;
			else
				prize = 50;
		}

		public void DisplayWinNumAndPrize(string _winningNumber = "?", string _prizeValue = "$?")
		{
			Console.WriteLine("\tWinning Number\t\tPrize Value");
			Console.WriteLine($"\t{_winningNumber}             \t\t{_prizeValue}");
			Console.WriteLine();
		}

		public void DisplayBlankTicket()
		{
			for (int x = 1; x < 16; x++)
			{
				Console.Write("\t?");
				if (x % 5 == 0)
				{
					Console.WriteLine();
				}
			}
		}

		public void DisplayTicket()
		{
			// Display the Random Numbers
			for (int x = 1; x < 16; x++)
			{
				Console.Write($"\t{numbers[x - 1] } ");
				if (x % 5 == 0) // Does line break to print 5 numbers per row
				{
					Console.WriteLine();
				}
			}
			Console.WriteLine();
		}

		public void DisplayTotalWinnings ()
		{
			Console.WriteLine($"You won a total of {this.TotalWinnings:C}!");
			Console.WriteLine($"You spent a total of {this.CalculateTotalCost():C}.");
			if (this.CalculateNetGain() > 0)
			{
				Console.WriteLine($"You made {this.CalculateNetGain():C}!");
			}
			else
			{
				Console.WriteLine($"You owe {this.CalculateNetGain() * -1:C}!");
			}

		}

		public int CheckForWinner()
		{
			int numberOfMathes = 0;
			for (int x = 0; x < 15; x++)
			{
				if (numbers[x] == winningNumber)

					numberOfMathes++;
			}
			return numberOfMathes;
		}

		public void UpdateTotalWinnings(int val)
		{
			totalWinnings += val;
		}

		public int CalculateTotalCost ()
		{
			return this.TicketsSold * this.Price;
		}

		public int CalculateNetGain ()
		{
			return this.TotalWinnings - (this.TicketsSold * this.Price);
		}

	}
}