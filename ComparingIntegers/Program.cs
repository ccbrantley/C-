using System;

namespace ComparingIntegers
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Please enter an integer: ");
			string userFirstIntegerInput = Console.ReadLine();
			Console.Write("Please enter another integer: ");
			string userSecondIntegerInput = Console.ReadLine();
			int firstNumber = Convert.ToInt32(userFirstIntegerInput);
			int secondNumber = Convert.ToInt32(userSecondIntegerInput);
			if (firstNumber > secondNumber)
			{
				Console.WriteLine($"{firstNumber} is larger.");
			}
			else if (firstNumber < secondNumber)
			{
				Console.WriteLine($"{secondNumber} is larger.");
			}
			else
			{
				Console.WriteLine("These numbers are equal.");
			}
		}
	}
}