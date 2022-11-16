/*
using System;

namespace DuplicateElimination
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] array = new int [5];
			int count = 0;
			while (count < array.Length)
			{
				Console.WriteLine("Enter an unique integer (10 to 100): ");
				int userInput = int.Parse(Console.ReadLine());
				if (userInput > 9 && userInput < 101)
				{
					for (int index = 0; index < array.Length; ++index)
					{
						if (array[index] == 0)
						{
							array[index] = userInput;
							Console.WriteLine($"The integer {userInput} was unique!");
							count++;
							break;
						}
						else if (array[index] == userInput)
						{
							Console.WriteLine("The integer was not unique, please try again.");
							break;
						}
					}
				}
				else
				{
					Console.WriteLine("The input was invalid, please try again.");
				}
				Console.WriteLine();
			}
			Console.WriteLine("All unique integer inputs are listed below.");
			foreach (int elt in array)
			{
				Console.WriteLine(elt);
			}
		}
	}
}
*/