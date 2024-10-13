using System;

public class Address

{
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    private string _zipcode;

    public Address(string street, string city, string state, string country, string zipcode)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
        _zipcode = zipcode;
    }

    public string Street
    {
        get { return _street; }
        set { _street = value; }
    }
    public string City
    {
        get { return _city; }
        set { _city = value; }
    }
    public string State
    {
        get { return _state; }
        set { _state = value; }
    }
    public string Country
    {
        get { return _country; }
        set { _country = value; }
    }
    public string Zipcode
    {
        get { return _zipcode; }
        set { _zipcode = value; }
    }

    public bool IsInUSA()
    {
        return _country.ToLower() == "usa";
    }
    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_state} {_country}\n{_zipcode}\n";
    }
}

// Address
// The address contains a string for the street address, the city, state/province, and country.
// The address should have a method that can return whether it is in the USA or not.
// The address should have a method to return a string all of its fields together in one string (with newline characters where appropriate)