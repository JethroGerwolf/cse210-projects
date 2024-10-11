using System;
using System.Data;
using System.Reflection.Metadata.Ecma335;

class Order
{
    private Customer _customer;
    private List<Product> _products;
    private double _shippingCost;
    public Order(Customer customer, List<Product> products)
    {   
        _customer = customer;
        _products = products;
        _shippingCost = customer.IsInUSA() ? 5 : 35;
    }
    public double TotalCost()
    {
        double totalProductCost = _products.Sum(p => p.getTotalCost());
        return totalProductCost + _shippingCost;
    }
    public string PackingLabel()
    {
        return string.Join("\n", _products.Select(p => $"{p.getproductname()} (ID: {p.getproductID()})"));
    }
    public string ShippingLabel()
    {
        return $"{_customer.name()}\n{_customer.addy()}";
    }
}
