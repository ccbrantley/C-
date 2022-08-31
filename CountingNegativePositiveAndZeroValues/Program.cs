using System;

namespace CountingNegativePostiveAndZeroValues
{
	class Program
	{
		static void Main(string[] args)
		{
			int negativeCounter = 0;
			int positiveCounter = 0;
			int zeroCounter = 0;
			Console.WriteLine("Please enter five numbers.");
			for (int counter = 0; counter < 5; counter++)
			{
				if (counter < 1)
				{
					Console.Write("Enter a number ({0}): ", counter + 1);
				}
				else
				{
					Console.Write("Enter another number ({0}): ", counter + 1);
				}
				string userNumberInput = Console.ReadLine();
				int userNumber = Convert.ToInt32(userNumberInput);
				if (userNumber < 0)
				{
					negativeCounter++;
				}
				else if (userNumber == 0)
				{
					zeroCounter++;
				}
				else
				{
					positiveCounter++;
				}
			}
			Console.WriteLine($"Number of negative numbers: {negativeCounter}");
			Console.WriteLine($"Number of positive numbers: {positiveCounter}");
			Console.WriteLine($"Number of zeros: {zeroCounter}");
		}
	}
}