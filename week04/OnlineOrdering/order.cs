public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    private int GetShippingCost()
    {
        if (_customer.LiveInUSA())
        {
            return 5;

        }
        else
        {
            return 35;
        }

    }
    public int GetTotalCost()
    {
        int total = 0;
        foreach (Product product in _products)
        {
            total += product.GetTotalCost();

        }
        total = total + GetShippingCost();
        return total;
    }
    public string GetPackingLabel()
    {
        string label = "";

        foreach (Product product in _products)
        {
            label += $"{product.GetName()} ({product.GetId()})\n";
        }
        return label;
    }
    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress()}";
    }

}