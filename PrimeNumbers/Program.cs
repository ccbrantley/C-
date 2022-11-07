using System;

namespace PrimeNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			for (int i = 2; i < 10001; i++)
			{
				if (Prime(i))
				{
					Console.WriteLine($"{i} is a prime number");
				}
			}
		}
		static bool Prime (int _number)
		{
			int upperLimit = (int) (Math.Pow(_number, 1 / 2.0) + .5);
			for (int i = 2; i < upperLimit + 1; i ++)
			{
				if ((_number % i) == 0)
				{
					return false;
				}
			}
			return true;
		}
	}
}
