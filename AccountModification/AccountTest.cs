// Exercise 4.9 Solution: AccountTest.cs
// Create and manipulate Account objects with a Debit method.
using System;

class AccountTest
{
   static void Main()
   {
      Account account1 = new Account("Jane Green", 50.00m);
      Account account2 = new Account("John Blue", -7.53m);

      // display initial balance of each object
      Console.WriteLine(
         $"{account1.Name}'s balance: {account1.Balance:C}");
      Console.WriteLine(
         $"{account2.Name}'s balance: {account2.Balance:C}");

      // prompt for then read input
      Console.Write("\nEnter deposit amount for account1: ");
      decimal depositAmount = decimal.Parse(Console.ReadLine());
      Console.WriteLine(
         $"adding {depositAmount:C} to account1 balance\n");
      account1.Deposit(depositAmount); // add to account1's balance

      // display balances
      Console.WriteLine(
         $"{account1.Name}'s balance: {account1.Balance:C}");
      Console.WriteLine(
         $"{account2.Name}'s balance: {account2.Balance:C}");

      // prompt for then read input
      Console.Write("\nEnter deposit amount for account2: ");
      depositAmount = decimal.Parse(Console.ReadLine());
      Console.WriteLine(
         $"adding {depositAmount:C} to account2 balance\n");
      account2.Deposit(depositAmount); // add to account2's balance

      // display balances
      Console.WriteLine(
         $"{account1.Name}'s balance: {account1.Balance:C}");
      Console.WriteLine(
         $"{account2.Name}'s balance: {account2.Balance:C}");

      decimal withdrawalAmount; // withdrawal amount entered by user

      // prompt for then read input
      Console.Write("Enter withdrawal amount for account1: ");
      withdrawalAmount = decimal.Parse(Console.ReadLine());
      Console.WriteLine(
         $"subtracting {withdrawalAmount:C} from account1 balance\n");
      // subtract amount from account1
      account1.Withdraw(withdrawalAmount);

      // display balances
      Console.WriteLine(
         $"{account1.Name}'s balance: {account1.Balance:C}");
      Console.WriteLine(
         $"{account2.Name}'s balance: {account2.Balance:C}");

      // prompt for then read input
      Console.Write("Enter withdrawal amount for account2: ");
      withdrawalAmount = decimal.Parse(Console.ReadLine());
      Console.WriteLine(
         $"subtracting {withdrawalAmount:C} from account2 balance\n");
      // subtract amount from account1
      account2.Withdraw(withdrawalAmount);

      // display balances
      Console.WriteLine(
         $"{account1.Name}'s balance: {account1.Balance:C}");
      Console.WriteLine(
         $"{account2.Name}'s balance: {account2.Balance:C}");
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