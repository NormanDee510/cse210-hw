using System;
using System.Collections.Generic;

public class Order
{
    public List<Product> Products { get; private set; }
    public Customer Customer { get; private set; }

    public Order(Customer customer)
    {
        Products = new List<Product>();
        Customer = customer;
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public decimal GetTotalCost()
    {
        decimal totalCost = 0;
        foreach (var product in Products)
        {
            totalCost += product.GetTotalCost();
        }

        decimal shippingCost = Customer.IsInSA() ? 5 : 35;
        return totalCost + shippingCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";
        foreach (var product in Products)
        {
            packingLabel += $"{product.Name} (ID: {product.ProductId})\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{Customer.Name}\n{Customer.Address.GetFullAddress()}";
    }
}
