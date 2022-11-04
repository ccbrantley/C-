using System;

namespace Project2
{
	class Program
	{
		static void Main(string[] args)
		{
			DrinkMachine machine = new DrinkMachine();
			while (true)
			{
				machine.LoopStep();
			}
		}
	}
}