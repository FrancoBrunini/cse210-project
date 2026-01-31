using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("Almafuerte 890", "Bahía Blanca", "Buenos Aires", "Argentina");
        Customer customer = new Customer("Franco Bruñini", address);

        Product product1 = new Product("Anthony Edwards 1", "IE1223", 200, 1);
        Product product2 = new Product("Socks Adidas", "KJ1232", 10, 3);
        Order order = new Order(customer);
        order.AddProduct(product1);
        order.AddProduct(product2);
        Console.WriteLine("=== PACKING LABEL ===");
        Console.WriteLine(order.GetPackingLabel());

        Console.WriteLine("=== SHIPPING LABEL ===");
        Console.WriteLine(order.GetShippingLabel());

        Console.WriteLine("=== TOTAL COST ===");
        Console.WriteLine($"${order.GetTotalCost()}");








    }
}