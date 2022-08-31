using System;

namespace Arithmetic
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Please enter a number: ");
			string userFirstNumberInput = Console.ReadLine();
			Console.Write("Please enter another number: ");
			string userSecondNumberInput = Console.ReadLine();
			int firstNumber = Convert.ToInt32(userFirstNumberInput);
			int secondNumber = Convert.ToInt32(userSecondNumberInput);
			int sum = firstNumber + secondNumber;
			int product = firstNumber * secondNumber;
			int difference = firstNumber - secondNumber;
			int quotient = firstNumber / secondNumber;
			Console.WriteLine($"The sum is: {sum}");
			Console.WriteLine($"The product is: {product}");
			Console.WriteLine($"The difference is: {difference}");
			Console.WriteLine($"The quotient is: {quotient}");
		}
	}
}