using System;

public class Customer
{
    private string _fullName;
    private Address _address;

    public Customer(string fullName, Address address)
    {
        _fullName = fullName;
        _address = address;
    }

    public string FullName
    {
        get { return _fullName; }
        set { _fullName = value; }
    }
    public Address Address
    {
        get { return _address; }
        set { _address = value; }
    }
    
    public bool InUSA()
    {
        return _address != null && _address.IsInUSA();
    }
}


// Customer
// The customer contains a name and an address.
// The name is a string, but the Address is a class.
// The customer should have a method that can return whether they live in the USA or not. (Hint this should call a method on the address to find this.)