using System;
using System.Text;

namespace DisplayingTriangles
{
	class Program
	{
		static void Main(string[] args)
		{
			for (int i = 10; i > 0; i --)
			{
				for (int j = i; j < 11; j ++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
			Console.WriteLine();

			for (int i = 10; i > 0; i--)
			{
				for (int j = i; j > 0; j --)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
			Console.WriteLine();

			for (int i = 10; i > 0; i--)
			{
				for (int j = i; j < 10; j ++)
				{
					Console.Write(" ");
				}
				for (int j = i; j > 0; j --)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
			Console.WriteLine();

			for (int i = 10; i > 0; i--)
			{
				for (int j = i; j > 0; j --)
				{
					Console.Write(" ");
				}
				for (int j = i; j < 10; j++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
			Console.ReadLine();

		}
	}
}