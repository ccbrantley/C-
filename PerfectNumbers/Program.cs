using System;

namespace PerfectNumbers
{
	class Program
	{
		static void Main(string[] args)
		{

			for (int j = 2; j < 1001; j++)
			{
				int curTotal = 0;
				string factors = "";
				int lastNum = 0;
				for (int k = 1; k < (j / 2) + 1; k++)
				{
					if ((j % k) == 0)
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
						curTotal += k;
					}
				}
				if (lastNum > 0)
				{
					factors += $"and {lastNum}";
				}
				if (j == curTotal)
				{
					Console.WriteLine($"{j} is a perfect number. Its factors are {factors}.");
				}
			}
		}
	}
}