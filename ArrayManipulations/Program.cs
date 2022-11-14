using System;

namespace ArrayManipulations
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] array = {0, 0, 0};
			for (int count = 0; count < array.Length; ++count)
			{
				array[count] += 1;
			}
			foreach (int elt in array)
			{
				Console.WriteLine(elt);
			}
		}
	}
}