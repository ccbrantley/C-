using System;
class RPSGame
{
	private string playerMove;
	private string computerMove;
	private int draws;
	private int playerWins;
	private int computerWins;

	// Constructor to Create a New Rock, Paper, Scissors Game Object
	public RPSGame()
	{
	}
	public int Draws
	{
		get { return draws; }
	}
	public int PlayerWins
	{
		get { return playerWins; }
	}
	public int ComputerWins
	{
		get { return computerWins; }
	}
	public string PlayerMove     // Property to set or return player's move
	{
		get
		{
			return playerMove;
		}
		set
		{
			playerMove = value.ToUpper();
		}
	}
	public string ComputerMove     // Property to return computer's move
	{
		get
		{
			return computerMove;
		}
	}
	public void GetComputerMove()
	{
		Random rand = new Random();
		int move = rand.Next(3) + 1;  // Random number from 1 to 3
		if (move == 1)
			computerMove = "R";
		else if (move == 2)
			computerMove = "P";
		else
			computerMove = "S";
	}
	public string DisplayMoves()
	{
		string moves = "";
		string cMove = "", pMove = "";
		bool invalidMove = false;
		if (playerMove == "R")
			pMove = "Rock";
		else if (playerMove == "P")
			pMove = "Paper";
		else if (playerMove == "S")

			pMove = "Scissors";
		else
		{
			pMove = "\nInvalid entry...Must enter an R, P, or S.";
			invalidMove = true;
		}

		if (computerMove == "R")
			cMove = "Rock";
		else if (computerMove == "P")
			cMove = "Paper";
		else
			cMove = "Scissors";
		if (invalidMove)
			moves = pMove;
		else
			moves = ("\nPlayer's Move:   " + pMove +
					 "\nComputer's Move: " + cMove + "\n");
		return moves;
	}
	public string DetermineWinner()
	{
		//  R = Rock     P = Paper     S = Scissors
		string message = "";
		if (playerMove == computerMove)
		{
			message = ("It's a draw!");
			draws++;
		}
		else if (playerMove == "R" && computerMove == "P")
		{
			message = ("Computer Wins! Paper Covers Rock!");
			computerWins++;
		}
		else if (playerMove == "R" && computerMove == "S")
		{
			message = "Player Wins! Rock Smashes Scissors!";
			playerWins++;
		}
		else if (playerMove == "P" && computerMove == "R")
		{
			message = "Player Wins! Paper Covers Rock!";
			playerWins++;
		}
		else if (playerMove == "P" && computerMove == "S")
		{
			message = "Computer Wins! Scissors Cut Paper!";
			computerWins++;
		}
		else if (playerMove == "S" && computerMove == "R")
		{
			message = "Computer Wins! Rock Smashes Scissors!";
			computerWins++;
		}
		else if (playerMove == "S" && computerMove == "P")
		{
			message = "Player Wins! Sciccors Cut Paper!";
			playerWins++;
		}
		return message;
	}
	public string ShowStats()
	{

		string stats = ("Draws:           " + draws + "\n" +
						"Player Wins:     " + playerWins + "\n" +
						"Computer Wins:   " + computerWins + "\n");
		return stats;
	}
}