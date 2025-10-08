using System;
using System.Collections.Generic;

public class Address
{

    private string _streetAddress;
    private string _city;
    private string _state;
    private string _province;
    private string _country;
    
    public Address(string streetAddress, string city, string state, string province, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _province = province;
        _country = country;
    }


    public bool InTheUSA()
    {
        return _country.ToUpper() == "USA";
        
    }

    public string GetFullAddress()
    {
        if (InTheUSA())
        {
            return $"{_streetAddress}\n{_city}, {_state} {_country}";
        }
        else
        {
            return $"{_streetAddress}\n{_city}, {_province} {_country}";
        }

    }

    public void DisplayFullAddress()
    {
        Console.WriteLine(GetFullAddress());
        Console.WriteLine("");
    }
}
