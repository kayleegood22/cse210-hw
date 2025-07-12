using System.Collections.Generic;
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
        _products.Add(product);
    }

    public string PackingLabel()
    {
        StringBuilder sb = new StringBuilder();
        foreach (var product in _products)
        {
            sb.AppendLine($"{product.GetProductName()} (ID: {product.GetProductId()})");
        }
        return sb.ToString();
    }

    public string ShippingLabel()
    {
        return $"{_customer.GetCustomerName()}\n{_customer.GetAddress().CombinedAddress()}";
    }

    public int ShippingCost()
    {
        return _customer.LivesInUSA() ? 5 : 35;
    }

    public int TotalPrice()
    {
        int total = 0;
        foreach (var product in _products)
        {
            total += product.TotalCost();
        }
        return total + ShippingCost();
    }
}
