public class Product
{
    private string _productName;
    private int _productId;
    private int _pricePerUnit;
    private int _quantity;

    public Product(string productName, int productId, int pricePerUnit, int quantity)
    {
        _productName = productName;
        _productId = productId;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
    }

    public int TotalCost()
    {
        return _pricePerUnit * _quantity;
    }

    public string GetProductName()
    {
        return _productName;
    }

    public int GetProductId()
    {
        return _productId;
    }
}
