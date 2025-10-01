using System;
using System.Collections.Generic;

public class Product
{
    private string _name;
    private int _id;
    private decimal _price;
    private int _quantity;

    public Product (string name, int id, decimal price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public string GetProductName()
    {
        return _name;
    }

    public int GetProductId()
    {
        return _id;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public decimal GetPrice()
    {
        return _price;
    }

    public decimal GetTotalCostOfProduct()
    {
        return _price * _quantity;
    }

    public void Display()
    {
        Console.WriteLine($"Product: {_name} | Product ID: {_id} | Quantity: {_quantity} | Price: ${_price} | Total Price: ${this.GetTotalCostOfProduct()}");
    }
}
