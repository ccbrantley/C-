using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
	class MysteryNumber
	{
		public int RandomNumber { get; }

		public MysteryNumber()
		{
			RandomNumber = new Random().Next(1, 100);
		}
	}
}