using System;

class Program
{
    static void Main()
    {
        Address address1 = new Address("123 Main St", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("John Smith", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "P100", 800, 1));
        order1.AddProduct(new Product("Mouse", "P200", 25, 2));

        Address address2 = new Address("456 Queen St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Alice Brown", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Phone", "P300", 600, 1));
        order2.AddProduct(new Product("Headphones", "P400", 75, 1));
        order2.AddProduct(new Product("Charger", "P500", 20, 3));

        DisplayOrder(order1);
        DisplayOrder(order2);
    }

    static void DisplayOrder(Order order)
    {
        Console.WriteLine("---------------------------------");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order.GetTotalCost():0.00}");
        Console.WriteLine("---------------------------------\n");
    }
}