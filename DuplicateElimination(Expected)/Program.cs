using System;

namespace DuplicateElimination_Expected_
{
	class Program
	{
		static void Main(string[] args)
		{
			int counter = 0;
			int [] numberArray = new int [5];
			while (counter < 5)
			{
				Console.WriteLine("Please enter a number in the range 10 - 100: ");
				numberArray[counter] = int.Parse(Console.ReadLine());
				if (numberArray[counter] > 9 && numberArray[counter] < 101)
				{
					++counter;
				}
				else
				{
					Console.WriteLine("Invalid input, please try again.");
				}
			}
			Console.WriteLine();
			Console.WriteLine("The unique numbers from user input are listed below: "); 
			for (int index1 = 0; index1 < counter; ++ index1)
			{
				bool unique = true;
				for (int index2 = 0; index2 < counter; ++ index2)
				{
					if (index1 == index2)
					{
						continue;
					}
					else if (numberArray[index1] == numberArray[index2])
					{
						unique = false;
					}
				}
				if (unique)
				{
					Console.WriteLine(numberArray[index1]);
				}
			}
		}
	}
}