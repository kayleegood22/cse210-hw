public class Customer
{
    private string _customerName;
    private Address _address;

    public Customer(string customerName, Address address)
    {
        _customerName = customerName;
        _address = address;
    }

    public string GetCustomerName()
    {
        return _customerName;
    }

    public Address GetAddress()
    {
        return _address;
    }

    public bool LivesInUSA()
    {
        return _address.InUSA();
    }
}
