using System;

namespace PerfectNumbers
{
	class Program
	{

		static void Main(string[] args)
		{

			for (int j = 2; j < 1001; j++)
			{
				if (Perfect(j))
				{
					Console.WriteLine($"{j} is a perfect number. Its factors are {GetFactors(j)}.");
				}
			}
		}

		static bool Perfect (int _number)
		{
			int curTotal = 0;
			for (int k = 1; k < (_number / 2) + 1; k++)
			{
				if ((_number % k) == 0)
				{
					curTotal += k;
				}
			}
			if (curTotal == _number)
			{
				return true;
			}
			return false;
		}

		static string GetFactors (int _number)
		{
			int lastNum = -1;
			string factors = "";
			for (int k = 1; k < (_number / 2); k++)
			{
				if ((+_number % k) == 0)
				{
					if (lastNum < 1)
					{
						lastNum = k;
					}
					else
					{
						factors += $"{lastNum}, ";
						lastNum = k;
					}
				}
			}
			if (lastNum > 0)
			{
				factors += $"and {lastNum}";
			}
			return factors;
		}

	}
}