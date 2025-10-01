using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        if (product != null)
        {
        _products.Add(product);
        }
    }

    public decimal GetTotalCost()
    {
        return _products.Sum(p => p.GetTotalCostOfProduct());
    }

    public string GetPackingLabel()
    {
        string label = $"Packing Label for Order: \n";

        if (_customer != null)
        {
            label += $"Customer: {_customer.GetCustomerName()}\n";
        }
        else
        {
            label += $"Customer: [Unknown]\n";
        }

        label += $"Products: \n";
        foreach (Product product in _products)
        {
            label += $" - {product.GetProductName()} ~ ID: {product.GetProductId()}\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        string label = $"Shipping Label: \n";
        if (_customer != null)
        {
            label += $"Name: {_customer.GetCustomerName()}\n";
            label += $"Address: \n{_customer.GetCustomerAddress().GetFullAddress()}\n";
        }
        else
        {
            label += $"Name: [Unknown]\n";
            label += $"Address: [Unknown]\n";
        }

        return label;
    }

    public void DisplayAll()
    {
        if (_customer != null)
        {
           _customer.DisplayAll();
        }
        else
        {
            Console.WriteLine("No customer information available.");
        }

        foreach (Product product in _products)
        {
            product.Display();
        }
    }
}