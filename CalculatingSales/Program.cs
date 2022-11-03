using System;

namespace CalculatingSales
{
	class Program
	{
		static void Main(string[] args)
		{
			int sentinel = 0;
			int quantity = 0;
			decimal total = 0.0m;
			while (sentinel != 4)
			{
				Console.Write("Please enter the product number (type 4 to exit): ");
				sentinel = int.Parse(Console.ReadLine());
				if (sentinel != 4){
					Console.Write("Please enter the product quantity: ");
					quantity = int.Parse(Console.ReadLine());
					if (quantity < 1)
					{
						Console.WriteLine($"{quantity} is an incorrect quantity, try again!");
					}
					else
					{
						switch (sentinel)
						{
							case 1:
								total += 2.98m * quantity;
								break;
							case 2:
								total += 4.50m * quantity;
								break;
							case 3:
								total += 9.98m * quantity;
								break;
							default:
								Console.WriteLine($"{sentinel} is an incorrect product number, try again!");
								break;
						}
					}
				}
				Console.WriteLine();
			}
			Console.WriteLine($"Total Retail Value: {total:C}");
		}
	}
}
