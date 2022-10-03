// Application to test class Employee.
using System;

class EmployeeTest
{
   static void Main()
   {
      Employee employee1 = new Employee("Bob", "Jones", 2875.00M);
      Employee employee2 = new Employee("Susan", "Baker", 3150.75M);

      // display employees
      Console.Write($"Employee 1: {employee1.FirstName} {employee1.LastName}; ");
      Console.WriteLine($" Yearly Salary: {(12 * employee1.MonthlySalary):C}");
      Console.Write($"Employee 2: {employee2.FirstName} {employee2.LastName}; ");
      Console.WriteLine($" Yearly Salary: {(12 * employee2.MonthlySalary):C}");

      // increase employee salaries by 10%
      Console.WriteLine("\nIncreasing employee salaries by 10%");
      employee1.MonthlySalary = employee1.MonthlySalary * 1.10M;
      employee2.MonthlySalary = employee2.MonthlySalary * 1.10M;

      // display employees with new yearly salary
      Console.Write($"Employee 1: {employee1.FirstName} {employee1.LastName}; ");
      Console.WriteLine($" Yearly Salary: {(12 * employee1.MonthlySalary):C}");
      Console.Write($"Employee 2: {employee2.FirstName} {employee2.LastName}; ");
      Console.WriteLine($" Yearly Salary: {(12 * employee2.MonthlySalary):C}");
   } 
}