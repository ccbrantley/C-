using System;
using System.Collections.Generic;
using System.Text;

class Date
{
	public int Month { get; set; }
	public int Day { get; set; }
	public int Year { get; set; }

	public Date (int _month, int _day, int _year)
	{
		Month = _month;
		Day = _day;
		Year = _year;
	}

	public void DisplayDate ()
	{
		Console.WriteLine($"{Month}/{Day}/{Year}");
	}

}