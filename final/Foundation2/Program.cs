using System;

class Program
{
    static void Main(string[] args)
    {
        // First Order (in US)
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("Joan Baez", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Notebook", 101, 4, 5));
        order1.AddProduct(new Product("Pen", 102, 2, 10));

        Console.WriteLine("Order 1:");
        DisplayOrderDetails(order1);
        Console.WriteLine();

        // Second Order (not in US)
        Address address2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Bob Dylan", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Water Bottle", 201, 15, 2));
        order2.AddProduct(new Product("Backpack", 202, 40, 1));
        order2.AddProduct(new Product("T-Shirt", 203, 10, 3));

        Console.WriteLine("Order 2:");
        DisplayOrderDetails(order2);
    }

    static void DisplayOrderDetails(Order order)
    {
        Console.WriteLine("Packing Label:\n" + order.PackingLabel());
        Console.WriteLine("Shipping Label:\n" + order.ShippingLabel());
        Console.WriteLine("Total Price: $" + order.TotalPrice());
    }
}
