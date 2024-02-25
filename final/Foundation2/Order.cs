public class Order
{
    Address _address = new Address();
    public List<Product> _products = new List<Product>();
    public List<string> _pLabel = new List<string>();
    public List<int> _productCount;
    private Customer _customer = new Customer();
    private Double _sum = 0;
    private Double _shippingCost;
    private int _quantity;
    private string _returned;
    double num;
    private int _count = 0;

    public void GetQuantity(int quantity)
    {
        _quantity = quantity;
    }
    public Double TotalPrice()
    {
        foreach (Product product in _products)
        {
            _sum += product.TotalCost(_quantity);
        }
        if (_address.USA())
        {
            _shippingCost = 5;
        }
        else
        {
            _shippingCost = 35;
        }
        num = _sum += _shippingCost;
        return num;
    }
    public string PackingLabel()
    {
        _productCount = new List<int>();
        foreach (Product item in _products)
        {
            _productCount.Add(_count);
            _count++;
        }
        foreach (int number in _productCount)
        {
            _pLabel.Add(_products[number].PL());
        }
        foreach (string item in _pLabel)
        {
            _returned = $"{_returned}\n{item}";
        }
        return _returned;
    }
    public string ShippingLabel()
    {
        return $"{_customer.Name()}\n{_address.Location()}";
    }
}