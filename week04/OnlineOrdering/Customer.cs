using System;
using System.Collections.Generic;

public class Customer
{
    public string _customerName;
    public Address _customerAddress;

    public Customer(string customerName, Address customerAddress)
    {
        _customerName = customerName;
        _customerAddress = customerAddress;
    }

    public string GetCustomerName()
    {
        return _customerName;
    }

    public Address GetCustomerAddress()
    {
        return _customerAddress;
    }

    public void DisplayAll()
    {
        Console.WriteLine($"Order for: ");
        Console.WriteLine($"{_customerName}");
        Console.WriteLine("");
        Console.WriteLine("Customer Address: ");
        _customerAddress.DisplayFullAddress();
    }
}
