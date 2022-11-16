using System;

namespace DuplicateElimination_Expected_
{
	class Program
	{
		static void Main(string[] args)
		{
			int arraySize = 5;
			int [] numberArray = new int [arraySize];
			for (int step = 0; step < arraySize; ++ step)
			{
				Console.WriteLine("Please enter a number in the range 10 - 100: ");
				numberArray[step] = int.Parse(Console.ReadLine());
				while (numberArray[step] < 10 || numberArray[step] > 100)
				{
					Console.WriteLine("Invalid input, please try again!");
					Console.WriteLine("Please enter a number in the range 10 - 100: ");
					numberArray[step] = int.Parse(Console.ReadLine());
				}
				bool unique = true;
				for (int index = 0; index < step; ++ index)
				{
					if (numberArray[index] == numberArray[step])
					{
						unique = false;
					}
				}
				if (unique)
				{
					Console.WriteLine($"{numberArray[step]} is an unique user input.");
				}
                else
                {
					Console.WriteLine($"{numberArray[step]} is not an unique user input.");
                }
				Console.WriteLine();
			}
			Console.WriteLine();

			Console.WriteLine("The unique numbers from user input are listed below: ");
			for (int index1 = 0; index1 < arraySize; ++ index1)
			{
				bool unique = true;
				for (int index2 = index1 - 1; index2 > - 1; -- index2)
				{
					if (numberArray[index1] == numberArray[index2])
					{
						unique = false;
					}
				}
				if (unique)
				{
					Console.WriteLine($"{numberArray[index1]}");
				}
			}
		}
	}
}