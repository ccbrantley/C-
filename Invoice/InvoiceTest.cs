// Exercise 4.12 Solution: InvoiceTest.cs
// Application to test class Invoice.
using System;

class InvoiceTest
{
   static void Main()
   {
      Invoice invoice1 = new Invoice("1234", "Hammer", 2, 14.95M);

      // display invoice1
      Console.WriteLine("Original invoice information");
      Console.WriteLine($"Part number: {invoice1.PartNumber}");
      Console.WriteLine($"Description: {invoice1.PartDescription}");
      Console.WriteLine($"Quantity: {invoice1.Quantity}");
      Console.WriteLine($"Price: {invoice1.PricePerItem:C}");
      Console.WriteLine($"Invoice amount: {invoice1.GetInvoiceAmount():C}");

      // change invoice1's data
      invoice1.PartNumber = "001234";
      invoice1.PartDescription = "Yellow Hammer";
      invoice1.Quantity = 3;
      invoice1.PricePerItem = 19.49M;

      // display invoice1 with new data
      Console.WriteLine("\nUpdated invoice information");
      Console.WriteLine($"Part number: {invoice1.PartNumber}");
      Console.WriteLine($"Description: {invoice1.PartDescription}");
      Console.WriteLine($"Quantity: {invoice1.Quantity}");
      Console.WriteLine($"Price: {invoice1.PricePerItem:C}");
      Console.WriteLine($"Invoice amount: {invoice1.GetInvoiceAmount():C}");

      Invoice invoice2 = new Invoice("5678", "PaintBrush", -5, -9.99M);

      // display invoice2
      Console.WriteLine("\nOriginal invoice information");
      Console.WriteLine($"Part number: {invoice2.PartNumber}");
      Console.WriteLine($"Description: {invoice2.PartDescription}");
      Console.WriteLine($"Quantity: {invoice2.Quantity}");
      Console.WriteLine($"Price: {invoice2.PricePerItem:C}");
      Console.WriteLine($"Invoice amount: {invoice2.GetInvoiceAmount():C}");

      // change invoice2's data
      invoice2.Quantity = 3;
      invoice2.PricePerItem = 9.49M;

      // display invoice2 with new data
      Console.WriteLine("\nUpdated invoice information");
      Console.WriteLine($"Part number: {invoice2.PartNumber}");
      Console.WriteLine($"Description: {invoice2.PartDescription}");
      Console.WriteLine($"Quantity: {invoice2.Quantity}");
      Console.WriteLine($"Price: {invoice2.PricePerItem:C}");
      Console.WriteLine($"Invoice amount: {invoice2.GetInvoiceAmount():C}");
   } 
} 


/**************************************************************************
 * (C) Copyright 1992-2014 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 *************************************************************************/
