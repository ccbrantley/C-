using System;

namespace DuplicateElimination
{
	class Program2
	{
		static void Main(string[] args)
		{
			int[] array = new int[5];
			int count = 0;
			while (count < array.Length)
			{
				Console.WriteLine("Enter an unique integer (10 to 100): ");
				int userInput = int.Parse(Console.ReadLine());
				if (userInput > 9 && userInput < 101)
				{
					bool unique = true;
					for (int index = 0; index < count; ++index)
					{
						if (array[index] == userInput)
						{
							unique = false;
							Console.WriteLine("The integer was not unique, please try again.");
						}
					}
					if (unique)
					{
						array[count] = userInput;
						++count;
						Console.WriteLine($"The integer {userInput} was unique!");
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
