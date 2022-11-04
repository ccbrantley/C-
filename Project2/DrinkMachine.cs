using System;
using System.Collections.Generic;
using System.Text;

namespace Project2
{
	class DrinkMachine
	{
		int total = 0;

		public DrinkMachine ()
		{
		}

		public void LoopStep ()
		{
			Console.Clear();
			if (!IsTotalEnough())
			{
				DisplayInsertCoin();
				Console.Write("Please insert coins or dollars (5, 10, 25, 100): ");
				DepositCoin(int.Parse(Console.ReadLine()));
			}
			else
			{
				DisplayDrinkSelection();
				Console.Write("Please select a drink: ");
				if (MakeDrinkSelection(int.Parse(Console.ReadLine())))
				{
					total -= 150;
					if (total > 0)
					{
						Console.Clear();
						DispenseChange();
					}
				}
			}
		}

		public void DepositCoin (int _coin)
		{
			if (_coin == 5 || _coin == 10 || _coin == 25 || _coin == 100)
			{
				total += _coin;
			}
			else
			{
				Console.WriteLine("Coin Rejected!");
				DisplayPause();
			}
		}

		public bool MakeDrinkSelection (int _selection)
		{
			if (IsTotalEnough())
			{
				switch (_selection)
				{
					case 1:
						Console.WriteLine("Thanks for your purchase of a Dasani beverage!");
						break;
					case 2:
						Console.WriteLine("Thanks for your purchase of a Sprite beverage!");
						break;
					case 3:
						Console.WriteLine("Thanks for your purchase of a Sprite Zero beverage!");
						break;
					case 4:
						Console.WriteLine("Thanks for your purchase of a Coca Cola beverage!");
						break;
					case 5:
						Console.WriteLine("Thanks for your purchase of a Coca Cola Zero beverage!");
						break;
					case 6:
						Console.WriteLine("Thanks for your purchase of a Barq's Root Beer beverage!");
						break;
					case 7:
						Console.WriteLine("Thanks for your purchase of a Fanta beverage!");
						break;
					default:
						Console.WriteLine("Invalid Drink Selection, try again!");
						DisplayPause();
						return false;
				}
				DisplayPause();
				return true;
			}
			return false;
		}

		public bool IsTotalEnough ()
		{
			if (total > 149)
			{
				return true;
			}
			return false;
		}

		public void DispenseChange ()
		{
			string five = @"

                     #
               #           #   
           #                   #
        #                         #
       #                           #
      #           ########          #
     #            ##                 #
     #             ######            #
     #                  ##           #
      #            #######          #
       #                           #
          #                     #
              #             #
                     #                                                                                   
			";
			string twentyFive = @"

                     #
               #            #   
           #                    #
        #                         #
       #                           #
      #       ######  ########      #
     #       ##   ##  ##             #
     #           ##    ######        #
     #         ##           ##       #
      #      ########  #######      #
       #                           #
          #                     #
              #             #
                     #                                                                                   
			";
		int change = total;
		int quarters = 0;
		int nickels = 0;
		while (change > 0)
		{
			if (change > 24)
			{
				Console.WriteLine(twentyFive);
					change -= 25;
				quarters += 1;
			}
			else
			{
				Console.WriteLine(five);
				change -= 5;
				nickels += 1;
			}
		}
		Console.WriteLine($"You're change is {(total / 100.0m):C} and consists of {quarters} quarters and {nickels} nickels.");
		total = 0;
		DisplayPause();
		}

		public void DisplayPause ()
		{
			Console.WriteLine("Press \"Enter\" to continue.");
			Console.ReadLine();
		}

		public void DisplayDrinkSelection ()
		{
			Console.WriteLine("***********************");
			Console.WriteLine("*     ___________     *");
			Console.WriteLine("*     |Coca-Cola|     *");
			Console.WriteLine("*     -----------     *");
			Console.WriteLine("***********************");
			Console.WriteLine("*                     *");
			Console.WriteLine("*      1) Dasani      *");
			Console.WriteLine("*      2) Sprite      *");
			Console.WriteLine("*    3) Sprite Zero   *");
			Console.WriteLine("*     4) Coca Cola    *");
			Console.WriteLine("*  5) Coca Cola Zero  *");
			Console.WriteLine("* 6) Barq's Root Beer *");
			Console.WriteLine("*       7) Fanta      *");
			Console.WriteLine("*                     *");
			Console.WriteLine("*                     *");
			Console.WriteLine("***********************");
			Console.WriteLine("*  _________________  *");
			Console.WriteLine("*  |_______________|  *");
			Console.WriteLine("*                     *");
			Console.WriteLine("***********************");
		}

		public void DisplayInsertCoin ()
		{
			Console.WriteLine("***********************");
			Console.WriteLine("*     ___________     *");
			Console.WriteLine("*     |Coca-Cola|     *");
			Console.WriteLine("*     -----------     *");
			Console.WriteLine("***********************");
			Console.WriteLine("*                     *");
			Console.WriteLine("*    PLEASE INSERT    *");
			Console.WriteLine("*      COINS  OR      *");
			Console.WriteLine("*       DOLLARS       *");
			Console.WriteLine("*   (5, 10, 25, 100)  *");
			Console.WriteLine($"*     Total: {total / 100.0m:C}    *");
			Console.WriteLine("*         (|)         *");
			Console.WriteLine("*      _________      *");
			Console.WriteLine("*      |=======|      *");
			Console.WriteLine("*                     *");
			Console.WriteLine("***********************");
			Console.WriteLine("*  _________________  *");
			Console.WriteLine("*  |_______________|  *");
			Console.WriteLine("*                     *");
			Console.WriteLine("***********************");
		}

	}
}