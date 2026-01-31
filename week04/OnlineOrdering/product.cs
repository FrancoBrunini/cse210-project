using System.Data.Common;

public class Product
{
    private string _name;
    private string _id;
    private int _price;
    private int _quantity;
    public Product (string name,string id,int price,int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }
    public int GetTotalCost()
{
    return _price * _quantity;
}
    public string GetName ()
    {
        return _name;
    }
    public string GetId ()
    {
        return _id;
    }

}