using System;
using System.Data;
using System.Reflection.Metadata.Ecma335;

class Customer
{

    private string _name;
    private Address _address;
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;

    }
    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }
    public string name()
    {
        return _name;
    }
    public string addy()
    {
        return _address.FullAddress();
    }
}
