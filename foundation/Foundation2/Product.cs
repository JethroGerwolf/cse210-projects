using System;
using System.Reflection.Metadata.Ecma335;

class Product
{
    private string _name;
    private int _productID;
    private double _price;
    private int _quantity;
    public Product (string name, int productID, double price, int quantity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }
    public double getTotalCost()
    {
        return _price * _quantity;
    }
    public int getproductID()
    {
        return _productID;
    }
    public string getproductname()
    {
        return _name;
    }
}
