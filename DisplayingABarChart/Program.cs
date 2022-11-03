using System;

namespace DisplayingABarChart
{
	class Program
	{
		static void Main(string[] args)
		{
			int counter = 0;
			int userInput;
			while (counter < 3)
			{
				Console.WriteLine("Please enter in a number (1 - 30): ");
				userInput = int.Parse(Console.ReadLine());
				if (userInput > 0 && userInput < 31)
				{
					for (int starCount = userInput; starCount > 0; starCount --)
					{
						Console.Write("*");
					}
					Console.WriteLine();
					counter += 1;
				}
				else
				{
					Console.WriteLine("The input is invalid, please enter in a number within the allowed range.");
				}
			}
		}
	}
}
