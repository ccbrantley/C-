using System;
using System.Collections.Generic;
using System.Text;

class Invoice
{
	public string PartNumber {get; set;}
	public string PartDescription {get; set;}
	private int quantity = 0;
	private decimal pricePerItem = 0;

	public Invoice (string _partNumber, string _partDescription, int _quantity, decimal _pricePerItem)
	{
		PartNumber = _partNumber;
		PartDescription = _partDescription;
		Quantity = _quantity;
		PricePerItem = _pricePerItem;
	}

	public int Quantity
	{
		get
		{
			return quantity;
		}
		set
		{
			if (value < 0)
			{
				return;
			}
			quantity = value;
		}
	}

	public decimal PricePerItem
	{
		get
		{
			return pricePerItem;
		}
		set
		{
			if (value < 0)
			{
				return;
			}
			pricePerItem = value;
		}
	}

	public decimal GetInvoiceAmount ()
	{
		return Quantity * PricePerItem;
	}
}