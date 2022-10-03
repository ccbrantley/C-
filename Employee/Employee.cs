using System;
using System.Collections.Generic;
using System.Text;

class Employee
{
	public string FirstName { get; set; }
	public string LastName { get; set; }
	private decimal monthlySalary = 0;

	public Employee (string _firstName, string _lastName, decimal _monthlySalary)
	{
		FirstName = _firstName;
		LastName = _lastName;
		MonthlySalary = _monthlySalary;
	}

	public decimal MonthlySalary 
	{
		get
		{
			return monthlySalary;
		}
		set
		{
			if (value < 0)
			{
				return;
			}
			monthlySalary = value;
		}
	}

}