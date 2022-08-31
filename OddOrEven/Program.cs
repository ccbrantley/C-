using System;

namespace OddOrEven
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Please enter an integer: ");
			string userInput = Console.ReadLine();
			int number = Convert.ToInt32(userInput);
			int remainder = number % 2;
			if (remainder == 0)
			{
				Console.WriteLine($"{number} is even.");
			}
			else
			{
				Console.WriteLine($"{number} is odd.");
			}
		}
	}
}