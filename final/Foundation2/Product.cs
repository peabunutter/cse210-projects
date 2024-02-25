public class Product
{
    private string _name;
    private string _productID;
    private Double _price;
    private int _quantity;
    
    public Product(string name, string ID, Double price)
    {
        _name = name;
        _productID = ID;
        _price = price;
    }
    public Double TotalCost(int quantity)
    {
        return _price * quantity;
    }
    public string PL()
    {
        return $"\n{_quantity}x {_name}, {_productID}";
    }
    public void GetQuantity(int quantity)
    {
        _quantity = quantity;
    }
}