using System;

class Program
{
    static void Main()
    {
        // Creating Address objects
        Address address1 = new Address("140 Main St", "Johannesburg", "Gauteng", "SA");
        Address address2 = new Address("456 Oak Ave", "Toronto", "ON", "Canada");

        // Creating Customer objects
        Customer customer1 = new Customer("Nkululeko Donga", address1);
        Customer customer2 = new Customer("Thapelo Murena", address2);

        // Creating Product objects
        Product product1 = new Product("Laptop", 101, 800.00m, 1);
        Product product2 = new Product("Mouse", 102, 25.00m, 2);
        Product product3 = new Product("Headphones", 103, 50.00m, 3);

        // Creating Order objects
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);

        // Display order details
        DisplayOrderDetails(order1);
        DisplayOrderDetails(order2);
    }

    static void DisplayOrderDetails(Order order)
    {
        Console.WriteLine("Order Details:");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Cost: R{order.GetTotalCost():F2}");
        Console.WriteLine();
    }
}
