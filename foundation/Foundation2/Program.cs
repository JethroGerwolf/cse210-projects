using System;

class Program
{
    static void Main(string[] args)
    {
  
        Address address1 = new Address("123 Elm St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");

        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);  

        Product product1 = new Product("Laptop", 101, 1000, 1);
        Product product2 = new Product("Headphones", 102, 100, 2);
        Product product3 = new Product("Phone", 103, 500, 1);

        Order order1 = new Order(customer1, new List<Product> { product1, product2 });
        Order order2 = new Order(customer2, new List<Product> { product2, product3 });
    

        Console.WriteLine("Order 1:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine($"\nTotal Cost: ${order1.TotalCost():0.00}\n");


        Console.WriteLine("Order 2:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine($"\nTotal Cost: ${order2.TotalCost():0.00}");
    }
        
}
