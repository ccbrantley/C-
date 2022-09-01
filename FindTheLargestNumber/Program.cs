using System;

namespace FindTheLargestNumber
{
	class Program
	{
		static void Main(string[] args)
		{
			
			int number;
			int largest = int.MinValue;
			Console.WriteLine("Please enter 10 numbers.");
			for (int counter = 0; counter < 10; counter++)
			{
				if (counter == 0)
				{
					Console.Write("Enter a number ({0}): ", counter + 1);
				}
				else
				{
					Console.Write("Enter another number ({0}): ", counter + 1);
				}
				number = Convert.ToInt32(Console.ReadLine());
				if (number > largest)
				{
					largest = number;
				}
			}
			Console.WriteLine($"The largest number is: {largest}");
		}
	}
}