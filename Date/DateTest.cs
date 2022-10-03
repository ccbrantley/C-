// Application to test class Date.
using System;

class DateTest
{
   static void Main()
   {
      Date date1 = new Date(7, 4, 2004);

      Console.Write("The initial date is: ");
      date1.DisplayDate();

      // change date values
      date1.Month = 11;
      date1.Day = 1;
      date1.Year = 2003;

      Console.Write("\nDate with new values is: ");
      date1.DisplayDate();

      Console.WriteLine(); // output a new line
   } 
}